using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Kernel;

namespace _3
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Размерность случайной величины
        /// </summary>
        private int m_dimension_count;
        /// <summary>
        /// Нормальная корреляционная матрица
        /// </summary>
        private double[][] m_normal_correlation_matrix;
        /// <summary>
        /// Нормальная корреляционная матрица модели
        /// </summary>
        private double[][] m_calculated_normal_correlation_matrix;
        /// <summary>
        /// Корреляционная матрица
        /// </summary>
        private double[][] m_correlation_matrix;
        /// <summary>
        /// Матрица А для моделирования системы случайных величин с нормальным законом распределения
        /// </summary>
        private double[][] m_A;
        /// <summary>
        /// Математические ожидания (средние значения)
        /// </summary>
        private double[] m_mx;
        /// <summary>
        /// Математические ожидания (средние значения) модели
        /// </summary>
        private double[] m_calculated_mx;
        /// <summary>
        /// Дисперсии
        /// </summary>
        private double[] m_dx;
        /// <summary>
        /// Дисперсии модели
        /// </summary>
        private double[] m_calculated_dx;
        /// <summary>
        /// Случайные вектора
        /// </summary>
        private double[][] m_vectors;
        /// <summary>
        /// Количество случайных векторов
        /// </summary>
        private long m_vectors_count;
        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        private Random m_rand = new Random();
        private double m_normal_one_a = -3;
        private double m_normal_one_b = 3;
        //private double m_normal_one_max_F = 1 / Math.Sqrt(2 * Math.PI);
        private Bitmap m_bitmap;
        private const int MIN_BM_WIDTH_HEIGHT = 400;
        private const int ANGLE_RESOLUTION = 20;
        private const int F_RESOLUTION = 10;
        private int m_bitmap_width = MIN_BM_WIDTH_HEIGHT;
        private int m_bitmap_height = MIN_BM_WIDTH_HEIGHT;
        private double[] m_min;
        private double[] m_max;
        private int m_draw_x = 0;
        private int m_draw_y = 0;
        private int m_last_draw_x = 0;
        private int m_last_draw_y = 0;
        private bool m_draw_move = false;
        private bool m_locked = false;

        public frmMain()

        {
            InitializeComponent();
            UpdateBitmapSizes();
        }

        private double f(long i, int j, int k)
        {
            return Math.Exp(
                (1 - Math.Pow(m_calculated_normal_correlation_matrix[j][k], 2)) * (
                    Math.Pow(m_vectors[i][j] - m_calculated_mx[j], 2) / m_calculated_dx[j] -
                    2 * m_calculated_normal_correlation_matrix[j][k] * (m_vectors[i][j] - m_calculated_mx[j]) * (m_vectors[i][j] - m_vectors[i][k]) / Math.Sqrt(m_calculated_dx[j] * m_calculated_dx[i]) +
                    Math.Pow(m_vectors[i][k] - m_calculated_mx[k], 2) / m_calculated_dx[k]
                )
            ) / (2 * Math.PI * Math.Sqrt(m_calculated_dx[j] * m_calculated_dx[k] * (1 - Math.Pow(m_calculated_normal_correlation_matrix[j][k], 2))));
        }

        private double NormalOneF(double x)
        {
            return Math.Exp(-Math.Pow(x, 2)/2);
        }

        private int ToX(double x)
        {
            return (int)Math.Round(x) + m_draw_x;
        }

        private int ToX(double x, double minx, double maxx)
        {
            return ToX((x - minx) * m_bitmap_width / (maxx - minx));
        }

        private int ToX(long i)
        {
            int j = cbFirstDimension.SelectedIndex;
            int k = cbSecondDimension.SelectedIndex;
            return ToX(m_vectors[i][j], Math.Min(m_min[j], m_min[k]), Math.Max(m_max[j], m_max[k]));
        }

        private int ToY(double y)
        {
            return (int)Math.Round(m_bitmap_height - 1 - y) + m_draw_y;
        }

        private int ToY(double y, double miny, double maxy)
        {
            return ToY((y - miny) * m_bitmap_height / (maxy - miny));
        }

        private int ToY(long i)
        {
            int j = cbSecondDimension.SelectedIndex;
            int k = cbFirstDimension.SelectedIndex;
            return ToY(m_vectors[i][j], Math.Min(m_min[j], m_min[k]), Math.Max(m_max[j], m_max[k]));
        }

        private bool EnsurePoints(ref Point a, ref Point b)
        {
            double[][] borders = new double[4][] {
                new double[3] { 0, 1, 0 },
                new double[3] { -1, 0, m_bitmap_height },
                new double[3] { 0, -1, m_bitmap_width },
                new double[3] { 1, 0, 0 }
            };
            foreach (double[] line in borders)
            {
                double aline = line[0] * a.Y + line[1] * a.X + line[2];
                double bline = line[0] * b.Y + line[1] * a.X + line[2];
                if (aline > 0 && bline > 0) continue;
                if (aline < 0 && bline < 0) return false;
                Point p = (aline < 0) ? a : b;
                if (line[1] != 0)
                {
                    double x = (double)-line[2] / line[1];
                    p.Y = (int)Math.Truncate(a.Y + (x - a.X) * (b.Y - a.Y) / (b.X - a.X));
                    p.X = (int)Math.Truncate(x);
                }
                else
                {
                    double y = (double)-line[2] / line[0];
                    p.X = (int)Math.Truncate(a.X + (y - a.Y) * (b.X - a.X) / (b.Y - a.Y));
                    p.Y = (int)Math.Truncate(y);
                }
            }
            return true;
        }

        private void BrowseFile(string filter, Button button, TextBox textBox)
        {
            odParamsFile.Filter = filter;
            odParamsFile.FileName = textBox.Text;
            if (odParamsFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            textBox.Text = odParamsFile.FileName;
            button.Text = "Загрузить";
        }

        private void DrawIsoline(double sigma1, double sigma2, double r12, double a1, double a2, double min, double max, Pen p)
        {
            double c = 1 / (2 * Math.PI * sigma1 * sigma2);
            Graphics g = Graphics.FromImage(m_bitmap);
            double f = 1 / (2 * Math.PI * sigma1 * sigma2);
            int lines_count = F_RESOLUTION;
            double fh = f / lines_count;
            while (--lines_count > 0)
            {
                double alpha = 0;
                double sqrt = Math.Sqrt(
                    -2 * (1 - Math.Pow(r12, 2)) * Math.Log(f / c)
                );
                bool first = true;
                Point point1 = new Point();
                Point point2 = new Point();
                Point first_point = new Point();
                Point last_point = new Point();
                while (alpha < 2 * Math.PI)
                {
                    double subsqrt = Math.Max(Math.Sqrt(1 - r12 * Math.Sin(2 * alpha)), 1e-5);
                    Point point = new Point(
                        ToX(a1 + sigma1 * sqrt / subsqrt * Math.Cos(alpha), min, max),
                        ToY(a2 + sigma2 * sqrt / subsqrt * Math.Sin(alpha), min, max)
                    );
                    if (first)
                    {
                        first_point = point;
                        first = false;
                    }
                    else
                    {
                        point1 = last_point;
                        point2 = point;
                        if (EnsurePoints(ref point1, ref point2))
                        {
                            g.DrawLine(p, point1, point2);
                        }
                    }
                    last_point = point;

                    alpha += Math.PI / ANGLE_RESOLUTION;
                }
                point1 = last_point;
                point2 = first_point;
                if (EnsurePoints(ref point1, ref point2))
                {
                    g.DrawLine(p, point1, point2);
                }
                f -= fh;
            }
        }

        private void DrawBorders()
        {
            Graphics g = Graphics.FromImage(m_bitmap);
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(0, m_bitmap_height - 1));
            g.DrawLine(Pens.Black, new Point(0, m_bitmap_height - 1), new Point(m_bitmap_width - 1, m_bitmap_height - 1));
            g.DrawLine(Pens.Black, new Point(m_bitmap_width - 1, m_bitmap_height - 1), new Point(m_bitmap_width - 1, 0));
            g.DrawLine(Pens.Black, new Point(m_bitmap_width - 1, 0), new Point(0, 0));
        }

        private void GoGenerateData(frmProgress progress)
        {
            double[] n = new double[m_dimension_count];
            long li;
            ClearVectors();

            for (li = 0; li < m_vectors_count; ++li)
            {
                if (progress.Step()) break;

                double[] x = m_vectors[li];
                for (int i = 0; i < m_dimension_count; ++i)
                {
                    double n1, n2;
                    do
                    {
                        n1 = m_normal_one_a + (m_normal_one_b - m_normal_one_a) * m_rand.NextDouble();
                        n2 = m_rand.NextDouble();
                    } while (n2 > NormalOneF(n1));
                    n[i] = n1;
                }
                for (int i = 0; i < m_dimension_count; ++i)
                {
                    x[i] = m_mx[i];
                    for (int j = 0; j < m_dimension_count; ++j)
                    {
                        x[i] += m_A[i][j] * n[j];
                    }
                    m_min[i] = Math.Min(m_min[i], x[i]);
                    m_max[i] = Math.Max(m_max[i], x[i]);
                }
            }
            if (li < m_vectors_count)
            {
                Array.Resize<double[]>(ref m_vectors, (int) li);
            }
            m_vectors_count = li;
            nudVectorsCount.Value = m_vectors_count;
            cbModelIsoline.Enabled = true;
            cbCalculatedIsoline.Enabled = true;
            btnSave.Enabled = true;
            CalculateCharacteristics();
        }

        private void ClearVectors()
        {
            btnSave.Enabled = false;

            m_vectors = new double[m_vectors_count][];
            for (long i = 0; i < m_vectors.LongLength; ++i)
            {
                m_vectors[i] = new double[m_dimension_count];
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    m_vectors[i][j] = 0.0;
                }
            }
            m_min = new double[m_dimension_count];
            m_max = new double[m_dimension_count];
            m_calculated_mx = new double[m_dimension_count];
            for (int i = 0; i < m_dimension_count; ++i)
            {
                m_calculated_mx[i] = 0.0;
            }
            m_calculated_dx = new double[m_dimension_count];
            for (int i = 0; i < m_dimension_count; ++i)
            {
                m_calculated_dx[i] = 0.0;
            }
            m_calculated_normal_correlation_matrix = new double[m_dimension_count][];
            for (int i = 0; i < m_dimension_count; ++i)
            {
                m_calculated_normal_correlation_matrix[i] = new double[m_dimension_count];
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    m_calculated_normal_correlation_matrix[i][j] = 0.0;
                }
            }
        }

        private void CalculateCharacteristics()
        {
            // вектор средних
            for (long i = 0; i < m_vectors_count; ++i)
            {
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    m_calculated_mx[j] += m_vectors[i][j];
                }
            }
            for (int i = 0; i < m_dimension_count; ++i)
            {
                m_calculated_mx[i] /= m_vectors_count;
            }

            // корреляционная матрица
            for (long i = 0; i < m_vectors_count; ++i)
            {
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    for (int k = 0; k < m_dimension_count; ++k)
                    {
                        m_calculated_normal_correlation_matrix[j][k] +=
                            (m_vectors[i][j] - m_calculated_mx[j]) *
                            (m_vectors[i][k] - m_calculated_mx[k]);
                    }
                }
            }
            for (int i = 0; i < m_dimension_count; ++i)
            {
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    m_calculated_normal_correlation_matrix[i][j] /= m_vectors_count;
                }
            }

            double[] sqrt_dx = new double[m_dimension_count];
            // вектор дисперсий
            for (int i = 0; i < m_dimension_count; ++i)
            {
                m_calculated_dx[i] = m_calculated_normal_correlation_matrix[i][i];
                sqrt_dx[i] = Math.Sqrt(m_calculated_dx[i]);
            }

            // нормированная корреляционная матрица
            for (int i = 0; i < m_dimension_count; ++i)
            {
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    if (i == j)
                    {
                        m_calculated_normal_correlation_matrix[i][j] = 1.0;
                    }
                    else
                    {
                        m_calculated_normal_correlation_matrix[i][j] /= sqrt_dx[i] * sqrt_dx[j];
                    }
                }
            }

            UpdateCharacteristics();
        }

        private void UpdateCharacteristics()

        {
            string[] lines = new string[m_dimension_count];
            // вектор средних
            for (int i = 0; i < m_dimension_count; ++i)
            {
                lines[i] = m_calculated_mx[i].ToString("#0.000");
            }
            lbMx.Items.Clear();
            lbMx.Items.AddRange(lines);

            // вектор дисперсий
            for (int i = 0; i < m_dimension_count; ++i)
            {
                lines[i] = m_calculated_dx[i].ToString("#0.000");
            }
            lbDx.Items.Clear();
            lbDx.Items.AddRange(lines);

            // нормированная корреляционная матрица
            for (int i = 0; i < m_dimension_count; ++i)
            {
                lines[i] = "";
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    lines[i] += String.Format("{0:#0.000}\t", m_calculated_normal_correlation_matrix[i][j]);
                }
            }
            lbNormalCorrelationMatrix.Items.Clear();
            lbNormalCorrelationMatrix.Items.AddRange(lines);
        }

        private void UpdateDimensionList()
        {
            m_locked = true;
            int fi = cbFirstDimension.SelectedIndex;
            int si = cbSecondDimension.SelectedIndex;

            cbFirstDimension.Items.Clear();
            cbSecondDimension.Items.Clear();
            for (int i = 0; i < m_dimension_count; ++i)
            {
                cbFirstDimension.Items.Add(String.Format("X{0}", i + 1));
                cbSecondDimension.Items.Add(String.Format("X{0}", i + 1));
            }
            cbFirstDimension.SelectedIndex = (fi > m_dimension_count || fi < 0) ? (m_dimension_count > 0 ? 0 : -1) : fi;
            cbSecondDimension.SelectedIndex = (si > m_dimension_count) || si < 0 ? (m_dimension_count > 0 ? 0 : -1) : si;
            m_locked = false;
        }

        private void btnParamsFileLoad_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader(tbParamsFile.Text);

            // размерность
            m_dimension_count = Convert.ToInt32(tr.ReadLine());
            UpdateDimensionList();

            // загружаем вектор средних значений
            m_mx = new double[m_dimension_count];
            int i = 0;
            foreach (string v in tr.ReadLine().Split(' '))
            {
                if (i >= m_dimension_count) throw new Exception("Размерность вектора средних значений больше заданной размерности");
                m_mx[i++] = Convert.ToDouble(v);
            }

            // загружаем нормированную корреляционную матрицу
            m_normal_correlation_matrix = new double[m_dimension_count][];
            for (i = 0; i < m_dimension_count; ++i)
            {
                m_normal_correlation_matrix[i] = new double[m_dimension_count];
                int j = 0;
                foreach (string v in tr.ReadLine().Split(' '))
                {
                    if (j >= m_dimension_count) throw new Exception("Размерность строки значений больше заданной размерности");
                    m_normal_correlation_matrix[i][j++] = Convert.ToDouble(v);
                }
            }

            // загружаем вектор дисперсий
            i = 0;
            m_dx = new double[m_dimension_count];
            foreach (string v in tr.ReadLine().Split(' '))
            {
                if (i >= m_dimension_count) throw new Exception("Размерность вектора дисперсий больше заданной размерности");
                m_dx[i++] = Convert.ToDouble(v);
            }

            tr.Close();

            // вычисляем корреляционную матрицу
            m_correlation_matrix = new double[m_dimension_count][];
            for (i = 0; i < m_dimension_count; ++i)
            {
                m_correlation_matrix[i] = new double[m_dimension_count];
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    m_correlation_matrix[i][j] = m_normal_correlation_matrix[i][j] * Math.Sqrt(m_dx[i] * m_dx[j]);
                }
            }

            // вычисляем матрицу A для моделирования систем случайных величин
            m_A = new double[m_dimension_count][];
            for (i = 0; i < m_dimension_count; ++i)
            {
                m_A[i] = new double[m_dimension_count];
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    if (j > i)
                    {
                        m_A[i][j] = 0.0;
                    }
                    else
                    {
                        // FIXME: есть вероятность, что здесь ошибка
                        double sa1 = 0.0;
                        double sa2 = 0.0;
                        for (int k = 0; k < j; ++k)
                        {
                            sa1 += m_A[i][k] * m_A[j][k];
                            sa2 += Math.Pow(m_A[j][k], 2);
                        }
                        m_A[i][j] = (m_correlation_matrix[i][j] - sa1) / Math.Sqrt(m_correlation_matrix[j][j] - sa2);
                    }
                }
            }

            btnParamsFileLoad.Text = "Загружено";
            btnDataFileLoad.Text = "Загрузить";
            pnlDataGenerate.Enabled = true;
            cbModelIsoline.Enabled = true;
        }

        private void btnParamsFileBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile("Файл параметров (*.*)|*.*", btnParamsFileLoad, tbParamsFile);
        }

        private void btnDataFileLoad_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader(tbDataFile.Text);

            string line;
            m_vectors_count = 0;
            m_dimension_count = 0;
            // подсчитаем размерность и объем выборки
            while ((line = tr.ReadLine()) != null)
            {
                if (m_dimension_count == 0)
                {
                    m_dimension_count = line.Split(' ').Length;
                    UpdateDimensionList();
                }
                ++m_vectors_count;
            }

            tr.Close();

            tr = new StreamReader(tbDataFile.Text);

            ClearVectors();
            UpdateDimensionList();
            long i = 0;
            while ((line = tr.ReadLine()) != null)
            {
                string[] nums = line.Split(' ');
                if (nums.Length != m_dimension_count) throw new Exception("Размерность вектора данных не равен размерности первого вектора");
                for (int j = 0; j < m_dimension_count; ++j)
                {
                    m_vectors[i][j] = Convert.ToDouble(nums[j]);
                    m_min[j] = Math.Min(m_min[j], m_vectors[i][j]);
                    m_max[j] = Math.Max(m_max[j], m_vectors[i][j]);
                }
                ++i;
            }

            tr.Close();

            CalculateCharacteristics();

            btnDataFileLoad.Text = "Загружено";
            btnParamsFileLoad.Text = "Загрузить";
            pnlDataGenerate.Enabled = false;
            cbModelIsoline.Checked = cbModelIsoline.Enabled = false;
            cbCalculatedIsoline.Enabled = true;
            UpdateBitmap();
        }

        private void btnDataFileBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile("Файл данных (*.*)|*.*", btnDataFileLoad, tbDataFile);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            m_vectors_count = Convert.ToInt64(nudVectorsCount.Value);
            frmProgress.ShowProgress(m_vectors_count, this, GoGenerateData);
            UpdateBitmap();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sdVectorsToFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            TextWriter tw = new StreamWriter(sdVectorsToFile.FileName);

            for (long i = 0; i < m_vectors.LongLength; ++i)
            {
                for (int j = 0; j < m_dimension_count - 1; ++j)
                {
                    tw.Write("{0} ", m_vectors[i][j]);
                }
                tw.Write("{0}", m_vectors[i][m_dimension_count - 1]);
                tw.Write("\n");
            }

            tw.Close();
        }

        private void btnUpdateGraphic_Click(object sender, EventArgs e)
        {
            UpdateBitmap();
        }

        private void UpdateBitmap()
        {
            if (m_bitmap != null) m_bitmap.Dispose();

            m_bitmap = new Bitmap(m_bitmap_width, m_bitmap_height);

            if (cbModelPoints.Checked)
            {
                for (long i = 0; i < m_vectors_count; ++i)
                {
                    int x = ToX(i);
                    int y = ToY(i);
                    if (x < m_bitmap_width && x >= 0 && y < m_bitmap_height && y >= 0)
                    {
                        m_bitmap.SetPixel(x, y, Color.Blue);
                    }
                }
            }

            if (cbCalculatedIsoline.Checked)
            {
                int i = cbFirstDimension.SelectedIndex;
                int j = cbSecondDimension.SelectedIndex;
                DrawIsoline(
                    Math.Sqrt(m_calculated_dx[i]),
                    Math.Sqrt(m_calculated_dx[j]),
                    m_calculated_normal_correlation_matrix[i][j],
                    m_calculated_mx[i],
                    m_calculated_mx[j],
                    Math.Min(m_min[i], m_min[j]),
                    Math.Max(m_max[i], m_max[j]),
                    Pens.Red
                );
            }

            if (cbModelIsoline.Checked)
            {
                int i = cbFirstDimension.SelectedIndex;
                int j = cbSecondDimension.SelectedIndex;
                DrawIsoline(
                    Math.Sqrt(m_dx[i]),
                    Math.Sqrt(m_dx[j]),
                    m_normal_correlation_matrix[i][j],
                    m_mx[i],
                    m_mx[j],
                    Math.Min(m_min[i], m_min[j]),
                    Math.Max(m_max[i], m_max[j]),
                    Pens.Green
                );
            }

            DrawBorders();

            pbGraphics.Invalidate();
        }

        private void pbGraphics_Paint(object sender, PaintEventArgs e)
        {
            if (m_bitmap != null)
            {
                e.Graphics.DrawImage(
                    m_bitmap,
                    (pbGraphics.Width - m_bitmap.Width) / 2,
                    (pbGraphics.Height - m_bitmap.Height) / 2
                );
            }
        }

        private void pbGraphics_Resize(object sender, EventArgs e)
        {
            if (!UpdateBitmapSizes())
            {
                pbGraphics.Invalidate();
            }
        }

        private bool UpdateBitmapSizes()
        {
            int bitmap_width_height = Math.Max(MIN_BM_WIDTH_HEIGHT, Math.Min(pbGraphics.Width, pbGraphics.Height));
            if (bitmap_width_height != m_bitmap_width || bitmap_width_height != m_bitmap_height)
            {
                m_bitmap_height = m_bitmap_width = bitmap_width_height;
                UpdateBitmap();
                return true;
            }
            return false;
        }

        private void pbGraphics_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_draw_move = e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                m_last_draw_x = e.X;
                m_last_draw_y = e.Y;
            }
        }

        private void pbGraphics_MouseUp(object sender, MouseEventArgs e)
        {
            m_draw_move = false;
        }

        private void pbGraphics_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_draw_move)
            {
                m_draw_x += e.X - m_last_draw_x;
                m_last_draw_x = e.X;
                m_draw_y += e.Y - m_last_draw_y;
                m_last_draw_y = e.Y;
                UpdateBitmap();
            }
        }

        private void cbSecondDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_locked) UpdateBitmap();
        }

        private void cbModelIsoline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBitmap();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Kernel;

namespace _2._1
{
    public partial class frmMain : Form
    {
        private const int SUMS_COUNT = 10;

        private readonly double[] SUMS = new double[SUMS_COUNT]
        {
            -3, 3, 8, 9, 14, 15, 19, 20, 25, 30
            //-3, 15, 3, 9, 8, 30, 20, 19, 14, 25
        };

        private readonly double[] FREQUENCIES = new double[SUMS_COUNT]
        {
            0.008, 0.036, 0.06, 0.054, 0.18, 0.027, 0.15, 0.135, 0.225, 0.125
            //0.008, 0.027, 0.036, 0.054, 0.06, 0.125, 0.135, 0.15, 0.18, 0.225
        };

        private List<double> PROBABILITIES = null;

        private List<double> m_probabilities = new List<double>(SUMS_COUNT);

        private List<double> m_width_weight = new List<double>(SUMS_COUNT);

        private List<long> m_sum_frequencies = new List<long>(SUMS_COUNT);

        private long m_max_frequency;

        private long m_variates_count;

        private Drawing<long> m_drawerFreq;

        private Drawing<double> m_drawerProb;

        private int m_last_y;

        private void ClearModel()
        {
            m_max_frequency = 0;
            m_sum_frequencies.Clear();
            for (int i = 0; i < SUMS_COUNT; ++i) m_sum_frequencies.Add(0);
        }

        private void GoModel(frmProgress progress)
        {
            Random rand = new Random();
            double middle = 0.0;
            ClearModel();

            for (long i = 0; i < m_variates_count; ++i)
            {
                if (progress.Step())
                {
                    m_variates_count = i;
                    break;
                }

                double r = rand.NextDouble();
                for (int j = 0; j < SUMS_COUNT; ++j)
                {
                    if (r > PROBABILITIES[j]) continue;
                    m_max_frequency = Math.Max(m_max_frequency, ++m_sum_frequencies[j]);
                    middle += SUMS[j];
                    break;
                }
            }

            ProcessVariates(middle);
        }

        private void ProcessVariates(double middle)
        {
            nudVariatesCount.Value = m_variates_count;
            pbFrequencies.Invalidate();

            // среднее
            if (m_variates_count > 0)
            {
                middle /= m_variates_count;
            }
            lblMiddleValue.Text = middle.ToString();

            // дисперсия
            double dispersion = 0;
            for (int j = 0; j < SUMS_COUNT; ++j)
            {
                dispersion += Math.Pow(SUMS[j] - middle, 2) * m_sum_frequencies[j] / m_variates_count;
            }
            lblDispersionValue.Text = dispersion.ToString();

            // асимметрия
            double sigma3 = Math.Pow(Math.Sqrt(dispersion), 3);
            double asymmetry = 0.0;
            for (int j = 0; j < SUMS_COUNT; ++j)
            {
                asymmetry += Math.Pow(SUMS[j] - middle, 3) * m_sum_frequencies[j] / m_variates_count / sigma3;
            }
            lblAsymmetryValue.Text = asymmetry.ToString();

            // эксцесс
            double sigma4 = Math.Pow(Math.Sqrt(dispersion), 4);
            double excess = -3;
            for (int j = 0; j < SUMS_COUNT; ++j)
            {
                excess += Math.Pow(SUMS[j] - middle, 4) * m_sum_frequencies[j] / m_variates_count / sigma4;
            }
            lblExcessValue.Text = excess.ToString();

            m_probabilities.Clear();
            // данные для статистической функции
            for (int j = 0; j < SUMS_COUNT; ++j)
            {
                m_probabilities.Add((double) m_sum_frequencies[j] / m_variates_count + ((j > 0) ? m_probabilities[j - 1] : 0.0));
            }
            pbProbability.Invalidate();
        }

        private bool IsWantedSum(int index)
        {
            return index == 1;
        }

        private void SetInfo(int index)
        {
            lblSumValue.Text = SUMS[index].ToString();
            lblSumCountValue.Text = m_sum_frequencies[index].ToString();
            lblSumPieceOfValue.Text = ((double) m_sum_frequencies[index] / m_variates_count).ToString();
        }

        private void ProbabilityDrawer(PaintEventArgs e, Brush brush, Pen pen, int x, int y, int width, int height, int index)
        {
            int last_y = index > 0 ? m_last_y : (y + height);
            e.Graphics.DrawLines(pen, new Point[] { new Point(x, last_y), new Point(x, y), new Point(x + width, y) });
            e.Graphics.DrawString(SUMS[index].ToString(), Font, brush, new PointF(x - 1, y + height));
            e.Graphics.DrawString(m_probabilities[index].ToString(), Font, brush, new PointF(0, y - Font.Height / 2));
            m_last_y = y;
        }

        public frmMain()
        {
            InitializeComponent();

            PROBABILITIES = new List<double>(SUMS_COUNT);
            for (int i = 0; i < SUMS_COUNT; ++i)
            {
                PROBABILITIES.Add(FREQUENCIES[i] + ((i > 0) ? PROBABILITIES[i - 1] : 0));
            }
            m_drawerFreq = new Drawing<long>(pbFrequencies, SetInfo);
            m_drawerProb = new Drawing<double>(pbProbability, SetInfo, ProbabilityDrawer);
            double sum = 0;
            for (int i = 0; i < SUMS_COUNT; ++i) m_width_weight.Add((i < SUMS_COUNT - 1) ? (SUMS[i + 1] - SUMS[i]) : 5);
            for (int i = 0; i < SUMS_COUNT; ++i) sum += m_width_weight[i];
            for (int i = 0; i < SUMS_COUNT; ++i)
            {
                m_width_weight[i] *= SUMS_COUNT / sum;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            m_variates_count = Convert.ToInt64(nudVariatesCount.Value);
            frmProgress.ShowProgress(m_variates_count, this, GoModel);
        }

        private void pbFrequencies_Paint(object sender, PaintEventArgs e)
        {
            m_drawerFreq.Render(e, m_sum_frequencies, m_max_frequency, IsWantedSum);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            pbFrequencies.Invalidate();
        }

        private void pbGraphics_Resize(object sender, EventArgs e)
        {
            pbFrequencies.Invalidate();
        }

        private void pbProbability_Paint(object sender, PaintEventArgs e)
        {
            m_drawerProb.Render(e, m_probabilities, 1.0, null, m_width_weight);
        }

        private void pbFrequencies_MouseMove(object sender, MouseEventArgs e)
        {
            m_drawerFreq.SetLastX(e.X);
            pbFrequencies.Invalidate();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdVariates.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            FileStream input = new FileStream(ofdVariates.FileName, FileMode.Open, FileAccess.Read);
            try
            {
                const int BUFFER_SIZE = 65536;
                byte[] buffer = new byte[BUFFER_SIZE];
                int count = 0;
                double middle = 0.0;
                ClearModel();
                m_variates_count = 0;
                while ((count = input.Read(buffer, 0, BUFFER_SIZE)) != 0)
                {
                    m_variates_count += count;
                    for (int i = 0; i < count; ++i)
                    {
                        int b = buffer[i];
                        if (b > 127) b -= 256;
                        int index = Array.IndexOf(SUMS, b);
                        if (index == -1)
                        {
                            throw new Exception(String.Format("Плохое значение суммы очков: {0}", buffer[i]));
                        }
                        m_max_frequency = Math.Max(m_max_frequency, ++m_sum_frequencies[index]);
                        middle += SUMS[index];
                    }
                }
                ProcessVariates(middle);
            }
            finally
            {
                input.Close();
            }
        }
    }
}

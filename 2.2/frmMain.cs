using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Kernel;

namespace _2._2
{
    public partial class frmMain : Form
    {
        private readonly double A = 1 / Math.Sqrt(Math.PI);

        private int m_variates_count = 0;

        private int m_a = -50;
        private int m_b = 50;

        private int m_gistogramma_resolution = 20;

        private int m_gistogramma_a = -10;

        private int m_gistogramma_b = 10;

        private long m_gistogramma_max_value = 0;

        private List<double> m_variates = new List<double>();

        private List<long> m_gistogramma = new List<long>();

        private List<long> m_probability = new List<long>();

        private Drawing<long> m_drawerGistogramma;

        private Drawing<long> m_drawerProbability;

        private double Reverse_f(double f_value)
        {
            return Math.Sqrt(-Math.Log(f_value));
        }

        private double Native_f(double x_value)
        {
            return A * Math.Exp(-Math.Pow(x_value, 2));
        }

        private double Dispersion_f(double x_value, double middle)
        {
            return Math.Pow(x_value - middle, 2) * Native_f(x_value);
        }

        private double Asymmetry_f(double x_value, double middle)
        {
            return Math.Pow(x_value - middle, 3) * Native_f(x_value);
        }

        private double Excess_f(double x_value, double middle)
        {
            return Math.Pow(x_value - middle, 4) * Native_f(x_value);
        }

        private void ClearModel()
        {
            m_variates.Clear();
            m_variates.Capacity = m_variates_count;
        }

        private void ClearGistogramma()
        {
            m_gistogramma.Clear();
            m_gistogramma.Capacity = m_gistogramma_resolution;
            m_gistogramma_max_value = 1;
            m_probability.Clear();
            m_probability.Capacity = m_variates_count;
        }

        private void GoModel(frmProgress progress)
        {
            Random rand = new Random();
            double middle = 0.0;
            ClearModel();

            for (int i = 0; i < m_variates_count; ++i)
            {
                if (progress.Step())
                {
                    m_variates_count = i;
                    break;
                }

                double r, value;
                do
                {
                    r = rand.NextDouble();
                    value = m_a + rand.NextDouble() * (m_b - m_a);
                } while (r > Native_f(value));
                middle += value;
                m_variates.Add(value);
            }
            m_variates.Sort();

            ProcessVariates(middle);
        }

        private void ProcessVariates(double middle)
        {
            nudVariatesCount.Value = m_variates_count;
            pbGistogramma.Invalidate();

            // среднее
            if (m_variates_count > 0)
            {
                middle /= m_variates_count;
            }
            lblMiddleValue.Text = middle.ToString();

            // дисперсия
            double dispersion = 0;
            for (int j = 1; j < m_variates_count; ++j)
            {
                dispersion += (Dispersion_f(m_variates[j - 1], middle) + Dispersion_f(m_variates[j], middle)) / 2 * (m_variates[j] - m_variates[j - 1]);
            }
            lblDispersionValue.Text = dispersion.ToString();

            // асимметрия
            double sigma3 = Math.Pow(Math.Sqrt(dispersion), 3);
            double asymmetry = 0.0;
            for (int j = 1; j < m_variates_count; ++j)
            {
                asymmetry += (Asymmetry_f(m_variates[j - 1], middle) + Asymmetry_f(m_variates[j], middle)) / sigma3 / 2 * (m_variates[j] - m_variates[j - 1]);
            }
            lblAsymmetryValue.Text = asymmetry.ToString();

            // эксцесс
            double sigma4 = Math.Pow(Math.Sqrt(dispersion), 4);
            double excess = -3;
            for (int j = 1; j < m_variates_count; ++j)
            {
                excess += (Excess_f(m_variates[j - 1], middle) + Excess_f(m_variates[j], middle)) / sigma4 / 2 * (m_variates[j] - m_variates[j - 1]);
            }
            lblExcessValue.Text = excess.ToString();

            // данные для статистической функции
            GistogrammaUpdate();
        }

        private void GistogrammaUpdate()
        {
            m_gistogramma_a = Convert.ToInt32(nudGistogrammaAValue.Value);
            m_gistogramma_b = Convert.ToInt32(nudGistogrammaBValue.Value);
            m_gistogramma_resolution = Convert.ToInt32(nudGistogrammaResolutionValue.Value);
            ClearGistogramma();

            double h = (double)(m_gistogramma_b - m_gistogramma_a) / m_gistogramma_resolution;
            long count = 0;
            double b = m_gistogramma_a + h;
            for (int j = 0; j <= m_variates_count; ++j)
            {
                double val = (j < m_variates_count) ? m_variates[j] : m_gistogramma_b;
                if (val < m_gistogramma_a) continue;
                if (val >= m_gistogramma_b) break;
                if (val > b)
                {
                    m_gistogramma.Add(count);
                    long prev = m_probability.Count == 0 ? 0 : m_probability[m_probability.Count - 1];
                    m_probability.Add(prev + count);
                    m_gistogramma_max_value = Math.Max(m_gistogramma_max_value, count);
                    while (true)
                    {
                        b = b + h;
                        if (val <= b) break;
                        m_gistogramma.Add(0);
                        m_probability.Add(prev + count);
                    }
                    count = 0;
                }
                ++count;
            }
            pbGistogramma.Invalidate();
            pbProbability.Invalidate();
        }

        private bool IsWantedSum(int index)
        {
            return index == 1;
        }

        private void SetInfo(int index)
        {
            double h = (double)(m_gistogramma_b - m_gistogramma_a) / m_gistogramma_resolution;
            lblIntervalValue.Text = String.Format("[{0:F} ; {1:F}]", m_gistogramma_a + h * index, m_gistogramma_a + h * (index + 1));
            lblIntervalCountValue.Text = m_gistogramma[index].ToString();
            lblIntervalPieceOfValue.Text = ((double)m_probability[index] / m_variates_count).ToString();
        }

        public frmMain()
        {
            InitializeComponent();

            m_drawerGistogramma = new Drawing<long>(pbGistogramma, SetInfo);
            m_drawerProbability = new Drawing<long>(pbProbability, SetInfo);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            m_variates_count = Convert.ToInt32(nudVariatesCount.Value);
            frmProgress.ShowProgress(m_variates_count, this, GoModel);
        }

        private void pbGistogramma_Paint(object sender, PaintEventArgs e)
        {
            m_drawerGistogramma.Render(e, m_gistogramma, m_gistogramma_max_value, IsWantedSum);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            pbGistogramma.Invalidate();
        }

        private void pbGistogramma_Resize(object sender, EventArgs e)
        {
            pbGistogramma.Invalidate();
        }

        private void pbGistogramma_MouseMove(object sender, MouseEventArgs e)
        {
            m_drawerGistogramma.SetLastX(e.X);
            pbGistogramma.Invalidate();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdVariates.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            double middle = 0;
            ClearModel();
            FileStream input = new FileStream(ofdVariates.FileName, FileMode.Open, FileAccess.Read);
            try
            {
                m_variates_count = 0;
                StreamReader reader = new StreamReader(input);
                m_variates_count = Convert.ToInt32(reader.ReadLine().Trim());
                string[] nums = new string[0];
                int i = 0;
                int j = 0;
                while (i < m_variates_count)
                {
                    if (j == nums.Length)
                    {
                        nums = reader.ReadLine().Split(' ');
                        j = 0;
                    }
                    if (j >= nums.Length)
                    {
                        throw new Exception("Wrong number of numbers");
                    }
                    double val = Convert.ToDouble(nums[j++].Trim());
                    m_variates.Add(val);
                    middle += val;
                    ++i;
                }
            }
            finally
            {
                input.Close();
            }
            m_variates.Sort();
            ProcessVariates(middle);
        }

        private void btnGistogrammaUpdate_Click(object sender, EventArgs e)
        {
            GistogrammaUpdate();
        }

        private void pbProbability_Paint(object sender, PaintEventArgs e)
        {
            m_drawerProbability.Render(e, m_probability, m_variates_count, IsWantedSum);
        }

        private void pbProbability_Resize(object sender, EventArgs e)
        {
            pbProbability.Invalidate();
        }

        private void pbProbability_MouseMove(object sender, MouseEventArgs e)
        {
            m_drawerProbability.SetLastX(e.X);
            pbProbability.Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kernel;

namespace _1._2
{
    public partial class frmMain : Form
    {
        private double radius = 10;
        private int count;
        private int rand_max;
        private int wanted_count;
        private List<int> chords = new List<int>();
        private int max_frequency;
        private int wanted;
        private Drawing<int> drawer;

        public frmMain()
        {
            InitializeComponent();
            drawer = new Drawing<int>(pbGraphics, SetInfo);
        }

        private double drandom(double a, double b, int rand)
        {
            return a + (b - a) * rand / rand_max;
        }

        private void edRadius_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Double.TryParse(edRadius.Text, out radius);
        }

        private int GetIndexFromCoordinate(double c)
        {
            return Convert.ToInt32(Math.Truncate((c + radius) * rand_max / (2 * radius)));
        }

        private void GoModel(frmProgress progress)
        {
            Random rand = new Random();
            int tmp_count = Convert.ToInt32(edCount.Value);
            rand_max = Convert.ToInt32(edRandMax.Value);
            double point;
            double a = radius * Math.Sin(Math.PI / 3);
            wanted = GetIndexFromCoordinate(a);
            max_frequency = 0;
            chords.Clear();
            
            for (int i = 0; i < rand_max; ++i) chords.Add(0);

            wanted_count = 0;
            for (count = 0; count < tmp_count; ++count)
            {
                if (progress.Step()) break;
                int i = rand.Next(rand_max);
                point = Math.Abs(drandom(-radius, +radius, i));
                max_frequency = Math.Max(max_frequency, ++chords[i]);
                if (point > a) ++wanted_count;
            }
            edCount.Value = count;
            lblInfo.Text = String.Format("Частота: {0}", wanted_count * 1.0 / count);
            pbGraphics.Invalidate();
        }

        private void SetInfo(int index)
        {
        }

        private bool IsWantedChord(int index)
        {
            return index > wanted || index < rand_max - wanted - 1;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            frmProgress.ShowProgress(Convert.ToInt32(edCount.Value), this, GoModel);
       }

        private void pbGraphics_Paint(object sender, PaintEventArgs e)
        {
            drawer.Render(e, chords, max_frequency, IsWantedChord);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            pbGraphics.Invalidate();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            pbGraphics.Invalidate();
        }

        private void pbGraphics_MouseMove(object sender, MouseEventArgs e)
        {
            drawer.SetLastX(e.X);
            pbGraphics.Invalidate();
        }
    }
}

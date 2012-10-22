using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kernel;

namespace _1._1
{
    public partial class frmMain : Form
    {
        private const int EXTRACT_CARDS_COUNT = 3;
        private const int MAX_CARDS_SUM = 42;
        private const int MIN_CARDS_SUM = 18;
        private const int WANTED_CARDS_SUM = 21;
        private const int CARDS_NUM = 9;
        private const int MIN_CARD = 6;
        private const int MAX_CARD = 14;

        private int[] frequency = new int[0];
        private int max_frequency = 1;
        private Int64 count;
        private bool preview = false;
        private List<int> cards = null;
        private Drawing<int> drawer;

        public frmMain()
        {
            InitializeComponent();
            drawer = new Drawing<int>(pbGraphic, SetInfo);
        }

        private void DoModel(frmProgress progress)
        {
            Random rand = new Random();
            Int64 tmp_count = Convert.ToInt64(edCount.Value);
            frequency = new int[MAX_CARDS_SUM - MIN_CARDS_SUM + 1];
            max_frequency = 1;
            preview = cbPreview.Checked;

            if (cards == null)
            {
                cards = new List<int>(CARDS_NUM * 4);
                for (int j = 0; j < 4; ++j)
                {
                    for (int i = MIN_CARD; i <= MAX_CARD; ++i) cards.Add(i);
                }
            }

            for (count = 1; count <= tmp_count ; ++count)
            {
                if (progress.Step()) break;
                int sum = 0;
                for (int j = 0; j < EXTRACT_CARDS_COUNT; ++j)
                {
                    int k = rand.Next(CARDS_NUM - j - 1);
                    sum += cards[k];
                    cards.Add(cards[k]);
                    cards.Remove(cards[k]);
                }
                max_frequency = Math.Max(max_frequency, ++frequency[sum - MIN_CARDS_SUM]);
                if (preview) pbGraphic.Invalidate();
            }
            --count;
            edCount.Value = count;
            progress.Stop();
            preview = true;
            pbGraphic.Invalidate();
        }

        private void SetInfo(int index)
        {
            lblInfo.Text = String.Format("Сумма очков: {0}\nЧастота: {1}", index + MIN_CARDS_SUM, frequency[index] * 1.0 / count);
        }

        private bool IsWantedSum(int index)
        {
            return index + MIN_CARDS_SUM == WANTED_CARDS_SUM;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            frmProgress.ShowProgress(Convert.ToInt32(edCount.Value), this, DoModel);
        }

        private void pbGraphic_Paint(object sender, PaintEventArgs e)
        {
            drawer.Render(e, new List<int>(frequency), max_frequency, IsWantedSum);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            pbGraphic.Invalidate();
        }

        private void pbGraphic_MouseMove(object sender, MouseEventArgs e)
        {
            drawer.SetLastX(e.X);
            pbGraphic.Invalidate();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            pbGraphic.Invalidate();
        }
    }
}

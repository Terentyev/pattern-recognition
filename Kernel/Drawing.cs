using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Kernel
{
    public class Drawing<T>
    {
        public delegate void InfoSetter(int index);
        public delegate void Drawer(PaintEventArgs e, Brush brush, Pen pen, int x, int y, int width, int height, int index);

        static private Pen black_pen = new Pen(Color.Black);

        private PictureBox canvas;
        private InfoSetter infoSetter;
        private Drawer drawer;
        private int last_x;

        public Drawing(PictureBox canvas, InfoSetter infoSetter, Drawer drawer = null)
        {
            this.canvas = canvas;
            this.infoSetter = infoSetter;
            this.drawer = drawer;
        }

        public void SetLastX(int x)
        {
            last_x = x;
        }

        public void Render(PaintEventArgs e, List<T> elements, T max_element, Predicate<int> wanted, List<double> width_weight = null)
        {
            int shift = 10;
            int left = shift;
            int right = canvas.Width - shift;
            int top = shift;
            int bottom = canvas.Height - shift;
            e.Graphics.DrawLine(black_pen, new Point(top + shift, top), new Point(top + shift, bottom));
            e.Graphics.DrawLine(black_pen, new Point(left, bottom - shift), new Point(right, bottom - shift));
            if (elements.Count == 0) return;

            int step = (right - left - 2 * shift) / elements.Count;
            double vk = (bottom - top - 2 * shift) * 1.0 / Convert.ToDouble(max_element);
            bool should_set_default_info = last_x < shift * 5 / 2 || last_x > right - shift;
            for (int i = 0; i < elements.Count; ++i)
            {
                Brush brush = wanted != null && wanted(i) ? Brushes.Gold : Brushes.Blue;
                int width = width_weight != null ? Convert.ToInt32(step * width_weight[i]) : step;
                int height = Convert.ToInt32(vk * Convert.ToDouble(elements[i]));
                int x = shift * 5 / 2;
                if (width_weight != null) for (int k = 0; k < i; ++k) x += Convert.ToInt32(step * width_weight[k]);
                else x += i * step;
                int y = bottom - shift - height;

                if (x < last_x && last_x - x < width || should_set_default_info && wanted != null && wanted(i))
                {
                    brush = Brushes.Gold;
                    infoSetter(i);
                }

                if (drawer != null) drawer(e, brush, black_pen, x, y, width, height, i);
                else
                {
                    e.Graphics.FillRectangle(brush, x, y, width, height);
                    e.Graphics.DrawRectangle(black_pen, x, y, width, height);
                }
            }
        }
    }
}

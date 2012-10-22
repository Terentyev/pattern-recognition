using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    /// <summary>
    /// Единичный задержанный скачок
    /// </summary>
    class DelayedSingleLeap : SampledSignal
    {
        /// <summary>
        /// Задержка
        /// </summary>
        private double m_delay;

        public DelayedSingleLeap(double delay)
        {
            m_delay = delay;
        }

        protected override double calculate(double n)
        {
            return m_delay > n ? 0 : 1;
        }

        public override double max()
        {
            return 1;
        }

        public override double min()
        {
            return 0;
        }
    }
}

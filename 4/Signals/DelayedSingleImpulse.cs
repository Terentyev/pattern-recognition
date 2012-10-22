using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    /// <summary>
    /// Задержанный единичный импульс
    /// </summary>
    class DelayedSingleImpulse : SampledSignal
    {
        /// <summary>
        /// Задержка
        /// </summary>
        private double m_delay;

        public DelayedSingleImpulse(double delay)
        {
            m_delay = delay;
        }

        protected override double calculate(double n)
        {
            return Double.Equals(n, m_delay) ? 1 : 0;
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

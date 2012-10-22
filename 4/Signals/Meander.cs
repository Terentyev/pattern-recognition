using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    /// <summary>
    /// Меандер (прямоугольная решетка)
    /// </summary>
    class Meander : SampledSignal
    {
        /// <summary>
        /// Период
        /// </summary>
        private double m_period;

        public Meander(double period)
        {
            m_period = period;
        }

        protected override double calculate(double n)
        {
            return (n % m_period < m_period / 2) ? 1 : -1;
        }

        public override double max()
        {
            return 1;
        }

        public override double min()
        {
            return -1;
        }
    }
}

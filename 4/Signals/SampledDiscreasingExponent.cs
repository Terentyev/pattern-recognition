using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    /// <summary>
    /// Дискретизированная убывающая экспонента
    /// </summary>
    class SampledDiscreasingExponent : SampledSignal
    {
        /// <summary>
        /// Основание экспоненты
        /// </summary>
        private double m_base;

        public SampledDiscreasingExponent(double aBase)
        {
            m_base = aBase;
        }

        protected override double calculate(double n)
        {
            return Math.Pow(m_base, n);
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

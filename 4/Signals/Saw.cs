using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    class Saw : SampledSignal
    {
        private double m_period;

        public Saw(double period)
        {
            m_period = period;
        }

        protected override double calculate(double n)
        {
            return (n % m_period) / m_period;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    /// <summary>
    /// Дискретизированная синусоида
    /// </summary>
    class SampledSin : SampledSignal
    {
        /// <summary>
        /// Амплитуда
        /// </summary>
        private double m_amplitude;
        /// <summary>
        /// Частота
        /// </summary>
        private double m_frequency;
        /// <summary>
        /// Начальная фаза
        /// </summary>
        private double m_initial_phase;

        public SampledSin(double amplitude, double frequency, double initial_phase)
        {
            m_amplitude = amplitude;
            m_frequency = frequency;
            m_initial_phase = initial_phase;
        }

        protected override double calculate(double n)
        {
            return m_amplitude * Math.Sin(n * m_frequency + m_initial_phase);
        }

        public override double max()
        {
            return m_amplitude;
        }

        public override double min()
        {
            return -m_amplitude;
        }
    }
}

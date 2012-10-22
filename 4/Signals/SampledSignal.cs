using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    abstract class SampledSignal : BaseSignal
    {
        /// <summary>
        /// Текущий шаг
        /// </summary>
        private int m_current_step;

        /// <summary>
        /// Возвращает значение сигнала для данного момента "времени"
        /// </summary>
        /// <param name="n">Момент "времени"</param>
        /// <returns>Значение сигнала</returns>
        protected abstract double calculate(double n);

        public SampledSignal()
        {
            initializeSignal();
        }

        public void initializeSignal()
        {
            m_current_step = 0;
        }

        public override double nextValue()
        {
            return 0;
        }
    }
}

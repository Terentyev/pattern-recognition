using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Signals
{
    abstract class BaseSignal
    {
        /// <summary>
        /// Возвращает следующее значение сигнала
        /// </summary>
        /// <returns>Следующее значение сигнала</returns>
        public abstract double nextValue();

        /// <summary>
        /// Возвращает признак закончился ли сигнал
        /// </summary>
        /// <returns>true -- сигнал закончился, false -- сигнал ещё не закончился</returns>
        public abstract Boolean finished();

        /// <summary>
        /// Инициализация сигнала для начала сбора его значений
        /// </summary>
        public virtual void start()
        {
        }

        /// <summary>
        /// Возвращает максимально возможное значение сигнала
        /// </summary>
        /// <returns>Максимальное значение сигнала</returns>
        public abstract double max();

        /// <summary>
        /// Возвращает минимально возможное значение сигнала
        /// </summary>
        /// <returns>Минимальное значение сигнала</returns>
        public abstract double min();
    }
}

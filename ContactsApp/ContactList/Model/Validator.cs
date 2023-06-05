using System;

namespace ContactList.Model
{
    /// <summary>
    /// Хранит методы по валидации данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет количество символов строки в указанном диапазоне.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="min">Минимальное значение диапазона.</param>
        /// <param name="max">Максимальное значение диапазона.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов строки не входит в указанный диапазон.</exception>
        public static void AssertCountSymbolsInRange(string value, int min, int max, string nameProperty)
        {
            if (value.Length <= min || value.Length > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }

    }
}

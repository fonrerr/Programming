using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет количество символов строки в указанном диапазоне.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальное значение диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов строки не входит в указанный диапазон.</exception>
        public static void AssertStringOnLength(string value, int minLength, int maxLength, string propertyName)
        {
            if (value.Length < minLength || value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be between {minLength} and {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет количество символов строки в указанном диапазоне.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="maxLength">Максимальное значение диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов строки не входит в указанный диапазон.</exception>
        public static void AssertStringOnLength(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be between {minLength} and {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет количество символов строки в указанном диапазоне.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="maxLength">Максимальное значение диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов строки не входит в указанный диапазон.</exception>
        public static void AssertStringOnLength(int value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be between {minLength} and {maxLength}");
            }
        }

        public static void AssertSimbols(string value)
        {
            if(!Regex.IsMatch(value, @"^[A-Za-zА-яЁё]"))
            {
                throw new ArgumentException($"{value} Введено не корректно");
            }
        }
    }
}

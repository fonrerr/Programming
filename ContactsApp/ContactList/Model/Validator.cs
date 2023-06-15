using System;
using System.Text.RegularExpressions;

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
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит из ссылки.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        public static void AssertLink(string value)
        {
            if (!Regex.IsMatch(value, "^((http|https)://)[-a-zA-Z0-9@:%._\\+~#?&//=]{2,256}\\.[a-z]{2,6}\\b([-a-zA-Z0-9@:%._\\+~#?&//=]*)$"))
            {
                throw new ArgumentException($"{value} Введено не корректно");
            }
        }

        //TODO: Переименовать
        /// <summary>
        /// Проверяет, что строка состоит из цифр.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Имя свойства, которая подлежит проверки.</param>
        public static void AssertStringContainsOnlyNumbers(string value, string name)
        {
            if (!Regex.IsMatch(value, @"^[+]\d{11}$") && value != null)
            {
                throw new ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }
    }
}

namespace Programming.Models.Classes
{

    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Discipline
    {

        /// <summary>
        /// Хранит значение количесттва часов.
        /// </summary>
        private int _numberOfhours;

        /// <summary>
        /// Хранит значение баллов.
        /// </summary>
        private int _scores;

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает количество часов.Должно быть больше нуля.
        /// </summary>
        public int NumberOfHours
        {
            get { return _numberOfhours; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(NumberOfHours));
                _numberOfhours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество баллов. Должно быть большше нуля.
        /// </summary>
        public int Scores
        {
            get { return _scores; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Scores));
                _scores = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Discipline.
        /// </summary>
        public Discipline()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Discipline.
        /// </summary>
        /// <param name="title">Название дисциплины.</param>
        /// <param name="number">Количество часов.</param>
        /// <param name="scores">Количество баллов. Должно быть больше нуля.</param>
        public Discipline(string title, int number, int scores)
        {
            Title = title;
            NumberOfHours = number;
            Scores = scores;
        }
    }
}

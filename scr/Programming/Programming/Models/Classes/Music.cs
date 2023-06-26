namespace Programming.Models.Classes
{
    /// <summary>
    /// Хранит данные о музыке.
    /// </summary>
    public class Music
    {
        /// <summary>
        /// Хранит значение музыкальных групп.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Хранит значение жанров.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Хранит значение песен.
        /// </summary>
        public string Song { get; set; }

        /// <summary>
        /// Создает экземпляр класса Music.
        /// </summary>
        public Music()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        /// <param name="group">Музыкальная группа</param>
        /// <param name="genre">Музыкальный жанр</param>
        /// <param name="song">Песни</param>
        public Music(string group, string genre, string song)
        {
            Group = group;
            Genre = genre;
            Song = song;
        }
    }
}

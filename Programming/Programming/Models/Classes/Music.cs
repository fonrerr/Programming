namespace Programming.Models.Classes
{
    public class Music
    {
        //TODO: С заглавной буквы
        public string Group { get; set; }

        public string Genre { get; set; }

        public string Song { get; set; }

        public Music()
        {
        }

        public Music(string group, string genre, string song)
        {
            Group = group;
            Genre = genre;
            Song = song;
        }
    }
}

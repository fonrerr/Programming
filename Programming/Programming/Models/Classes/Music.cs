namespace Programming.Models.Classes
{
    public class Music
    {
        public string _group { get; set; }
        public string _genre { get; set; }
        public string _song { get; set; }

        public Music()
        {
        }

        public Music(string group, string genre, string song)
        {
            _group = group;
            _genre = genre;
            _song = song;
        }
    }
}

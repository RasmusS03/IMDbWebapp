namespace IMDbWebapp.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public Genre()
        {
            GenreName = "Unknown";
            GenreID = 0;
        }
        public Genre(int genreID, string genreName)
        {
            GenreID = genreID;
            GenreName = genreName;
        }
    }
}
namespace IMDbWebapp.Models
{
    public class MovieGenre
    {
        public int MovieID { get; set; }
        public int GenreID { get; set; }

        public MovieGenre()
        {
            MovieID = 0;
            GenreID = 0;
        }

        public MovieGenre(int movieID, int genreID)
        {
            MovieID = movieID;
            GenreID = genreID;
        }
    }
}
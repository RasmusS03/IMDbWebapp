namespace IMDbWebapp.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public int Rating { get; set; }

        public List<MovieCredit> Credits => FakeDatabase.MovieCredits.Where(c => c.MovieID == this.MovieID).ToList();

        public Movie()
        {
            MovieID = 0;
            Title = "Unknown";
            ReleaseDate = DateTime.Now;
            Duration = TimeSpan.Zero;
            Rating = 0;
        }

        public Movie(int movieID, string title, DateTime releaseDate, TimeSpan duration, int rating)
        {
            MovieID = movieID;
            Title = title;
            ReleaseDate = releaseDate;
            Duration = duration;
            Rating = rating;
        }
    }
}
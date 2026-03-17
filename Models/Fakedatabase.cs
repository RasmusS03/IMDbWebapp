using IMDbWebapp.Models;

//AI GENERERAD DATABAS
namespace IMDbWebapp
{
    public static class FakeDatabase
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>();
        public static List<Person> Persons { get; set; } = new List<Person>();
        public static List<Genre> Genres { get; set; } = new List<Genre>();
        public static List<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public static List<MovieCredit> MovieCredits { get; set; } = new List<MovieCredit>();

        static FakeDatabase()
        {
            // --- 1. GENRER ---
            Genres.AddRange(new List<Genre>
            {
                new Genre(1, "Sci-Fi"),
                new Genre(2, "Drama"),
                new Genre(3, "Action"),
                new Genre(4, "Crime"),
                new Genre(5, "Adventure")
            });

            // --- 2. PERSONER (Skådespelare & Regissörer) ---
            Persons.AddRange(new List<Person>
            {
                new Person(1, "Christopher Nolan", new DateTime(1970, 7, 30), "British"),
                new Person(2, "Matthew McConaughey", new DateTime(1969, 11, 4), "American"),
                new Person(3, "Anne Hathaway", new DateTime(1982, 11, 12), "American"),
                new Person(4, "Quentin Tarantino", new DateTime(1963, 3, 27), "American"),
                new Person(5, "Samuel L. Jackson", new DateTime(1948, 12, 21), "American"),
                new Person(6, "Leonardo DiCaprio", new DateTime(1974, 11, 11), "American"),
                new Person(7, "Cillian Murphy", new DateTime(1976, 5, 25), "Irish")
            });

            // --- 3. FILMER ---
            Movies.AddRange(new List<Movie>
            {
                new Movie(1, "Interstellar", new DateTime(2014, 11, 7), new TimeSpan(2, 49, 0), 9),
                new Movie(2, "Inception", new DateTime(2010, 7, 16), new TimeSpan(2, 28, 0), 9),
                new Movie(3, "Pulp Fiction", new DateTime(1994, 10, 14), new TimeSpan(2, 34, 0), 10),
                new Movie(4, "Oppenheimer", new DateTime(2023, 7, 21), new TimeSpan(3, 0, 0), 9),
                new Movie(5, "The Dark Knight", new DateTime(2008, 7, 18), new TimeSpan(2, 32, 0), 10)
            });

            // --- 4. KOPPLINGAR: MOVIE <-> GENRE ---
            MovieGenres.AddRange(new List<MovieGenre>
            {
                new MovieGenre(1, 1), // Interstellar - Sci-Fi
                new MovieGenre(1, 5), // Interstellar - Adventure
                new MovieGenre(2, 1), // Inception - Sci-Fi
                new MovieGenre(2, 3), // Inception - Action
                new MovieGenre(3, 4), // Pulp Fiction - Crime
                new MovieGenre(4, 2), // Oppenheimer - Drama
                new MovieGenre(5, 3), // The Dark Knight - Action
                new MovieGenre(5, 4)  // The Dark Knight - Crime
            });

            // --- 5. KOPPLINGAR: MOVIE <-> PERSON (Credits) ---
            MovieCredits.AddRange(new List<MovieCredit>
            {
                // Interstellar
                new MovieCredit(1, 1, "Director"),
                new MovieCredit(1, 2, "Actor (Cooper)"),
                new MovieCredit(1, 3, "Actor (Brand)"),

                // Inception
                new MovieCredit(2, 1, "Director"),
                new MovieCredit(2, 6, "Actor (Cobb)"),
                new MovieCredit(2, 7, "Actor (Fischer)"),

                // Pulp Fiction
                new MovieCredit(3, 4, "Director"),
                new MovieCredit(3, 5, "Actor (Jules Winnfield)"),

                // Oppenheimer
                new MovieCredit(4, 1, "Director"),
                new MovieCredit(4, 7, "Actor (J. Robert Oppenheimer)"),

                // The Dark Knight
                new MovieCredit(5, 1, "Director")
            });
        }
    }
}
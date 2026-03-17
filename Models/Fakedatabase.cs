namespace IMDbWebapp.Models {

    public static class FakeDatabase
    {
    public static List<Movie> Movies = new List<Movie>()
    {
        new Movie { MovieID = 1, Title = "Inception", Duration = TimeSpan.Zero, Rating = 9 },
        new Movie { MovieID = 2, Title = "Matrix", Duration = TimeSpan.Zero, Rating = 8 }
    };

    public static List<Person> Persons = new List<Person>()
    {
        new Person { PersonID = 1, Name = "Leonardo DiCaprio" },
        new Person { PersonID = 2, Name = "Keanu Reeves" }
    };
}
}
namespace IMDbWebapp.Models
{
    public class MovieCredit
    {
        public int MovieID { get; set; }
        public int PersonID { get; set; }
        public string RoleType { get; set; }

        public MovieCredit()
        {
            MovieID = 0;
            PersonID = 0;
            RoleType = "Unknown";
        }

        public MovieCredit(int movieID, int personID, string roleType)
        {
            MovieID = movieID;
            PersonID = personID;
            RoleType = roleType;
        }
    }
}
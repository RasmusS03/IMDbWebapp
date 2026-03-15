namespace IMDbWebapp.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }

        public Person()
        {
            PersonID = 0;
            Name = "Unknown";
            DateOfBirth = DateTime.Now;
            Nationality = "Unknown";
        }

        public Person(int personID, string name, DateTime dateOfBirth, string nationality)
        {
            PersonID = personID;
            Name = name;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
        }
    }
}
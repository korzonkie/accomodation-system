namespace accomodation_system
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}
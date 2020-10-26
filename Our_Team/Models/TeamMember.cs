using System;

namespace Our_Team
{
    public class TeamMember
    {
        public Guid Id { get; set; }
        //public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime DayOfBirth { get; set; }
        //public DateTime HireDate { get; set; }
        //public string ImageUrl { get; set; }

        public Project Project { get; set; }
    }
}
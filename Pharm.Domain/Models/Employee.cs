using System;


namespace Pharm.Domain.Models
{
    public class Employee : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

    }
}

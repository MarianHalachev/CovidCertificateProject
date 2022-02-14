namespace CovidCertificate.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Student
    {
        public Student()
        {
            this.Schools = new List<School>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PersonalNumber { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Residence { get; set; }
        public decimal Height { get; set; }
        public string ColorOfEyes { get; set; }
        public int Grade { get; set; }
        public int NumberInClass { get; set; }
        public string Sex { get; set; }
        public bool IsValid { get; set; }

        public ICollection<School> Schools { get; set; }


    }

}

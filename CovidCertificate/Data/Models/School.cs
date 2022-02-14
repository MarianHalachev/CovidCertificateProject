namespace CovidCertificate.Data.Models
{
    using CovidCertificate.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class School
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public string Location { get; set; }
        public TypeOfSchool TypeOfSchool { get; set; }
    }
}

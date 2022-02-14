using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCertificate.Data.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            this.Schools = new List<School>();
        }

        public ICollection<School> Schools { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using CovidCertificate.Data.Models;
namespace CovidCertificate.Data
{
    using CovidCertificate.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CovidCertificate.Data.Models.School> School { get; set; }
    }
}

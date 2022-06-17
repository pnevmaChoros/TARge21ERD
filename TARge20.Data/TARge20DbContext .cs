using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Access> Accesses { get; set; }

        public DbSet<AccessRight> AccessRights { get; set; }

        public DbSet<BorrowedStuff> BorrowedStuff { get; set;}

        public DbSet<Company> Company { get; set; }

        public DbSet<Child> Children { get; set; }

        public DbSet<EmployeeVacation>  EmployeeVacations { get; set; }

        public DbSet<Job> Job { get; set; }

        public DbSet<Office> Office { get; set; }

        public DbSet<Report> Report { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<Stuffs> Stuffs { get; set; }

        public DbSet<Vacation> Vacations { get; set; }
    }
}
using GuniThises.web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GuniThises.web.ViewModels;

namespace GuniThises.web.Data
{
    public class ApplicationDbContext
        : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    {
       public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        
        
        //public DbSet<Faculty> Faculty { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        
        //public DbSet<Faculty> Faculty { get; set; }


        public DbSet<GuniThises.web.ViewModels.StudentViewModel> StudentViewModel { get; set; }
    }

}

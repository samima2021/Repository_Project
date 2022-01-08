using Microsoft.EntityFrameworkCore;
using SCA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options)
        {

        }
        
        public DbSet<Student> students { get; set; }
       
    }
}

using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ToDoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RDQ6ANA\SQLEXPRESS;Database=ToDoList;Trusted_Connection=true;TrustServerCertificate=True");
        }
        public DbSet<Note> Note { get; set; }
    }
}

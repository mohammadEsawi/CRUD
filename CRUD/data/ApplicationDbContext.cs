using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.data
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ;Database=CrudDATA; Trusted_Connection=True;trustservercertificate=true");
        }

       public  DbSet<Employee> employees { get; set; } 
    }
}

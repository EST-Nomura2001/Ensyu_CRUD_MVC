using Microsoft.EntityFrameworkCore;
using Ensyu_CRUD_MVC.Models;

namespace Ensyu_CRUD_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }
    }
}

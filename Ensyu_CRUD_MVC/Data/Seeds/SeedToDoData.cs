using Ensyu_CRUD_MVC.Models;
using Ensyu_CRUD_MVC.Data;

namespace Ensyu_CRUD_MVC.Data.Seeds
{
    public class SeedToDoData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.ToDos.Any())
            {
                context.ToDos.Add(new ToDo
                {
                    Title = "予定",
                    Summary = "予定の概要",
                    FixedDate = DateTime.Now,
                });
                context.SaveChanges();
            }
        }
    }
}

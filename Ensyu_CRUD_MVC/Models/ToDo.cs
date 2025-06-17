using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ensyu_CRUD_MVC.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime FixedDate { get; set; }
    }
}

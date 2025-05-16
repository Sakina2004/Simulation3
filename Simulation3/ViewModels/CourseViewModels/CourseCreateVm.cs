using Simulation3.Models;

namespace Simulation3.ViewModels.CourseViewModels
{
    public class CourseCreateVm
    {
        public  IFormFile  Image { get; set; }
        public DateTime   Time { get; set; }
        public  string  Description { get; set; }
        public string Title { get; set; }
        public int CategoryId{ get; set; }
    }
}

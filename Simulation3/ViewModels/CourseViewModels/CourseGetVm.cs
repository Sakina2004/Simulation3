using Simulation3.Models;

namespace Simulation3.ViewModel.ProductViewModels
{
    public class CourseGetVm
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Trainer { get; set; }

    }
}
namespace Simulation3.ViewModels.CourseViewModels
{
    public class CourseUpdateVm
    {
        public int Id { get; set; }
        public IFormFile Image { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }

    }
}


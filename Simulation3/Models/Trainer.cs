using Simulation3.Models.Common;

namespace Simulation3.Models
{
    public class Trainer:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}

using Microsoft.CodeAnalysis.Operations;
using Simulation3.Models.Common;
using System.ComponentModel;

namespace Simulation3.Models
{
    public class Course:BaseEntity
    {
        public string ImagePath { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Trainer Category { get; set; }
    }
}

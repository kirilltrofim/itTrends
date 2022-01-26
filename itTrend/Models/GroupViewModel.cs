using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Models
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime StartYear { get; set; }
        public string specialization { get; set; }
        public int EducatorId { get; set; }
        public Educator Educator { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itTrend.Models;

namespace itTrend.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<Group> Groups { get; set; } = new List<Group>();
    }
}

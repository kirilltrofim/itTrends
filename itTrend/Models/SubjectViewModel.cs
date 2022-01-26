using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Models
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Educator> Educators { get; set; } = new List<Educator>();

    }
}

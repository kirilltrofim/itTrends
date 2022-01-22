using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using itTrend.Models;

namespace itTrend.Models
{
    public class Educator
    { 
        public int Id { get; set; }
        public string LastName { get; set; }
        public List<Group> Groups { get; set; } = new List<Group>();
        public string FirstName { get; set; }
        public string Patronomic { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
        public int SubjectId { get; set; }
        public Subject Subjects { get; set; }

    }
}

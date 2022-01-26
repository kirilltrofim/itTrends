using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronomic { get; set; }
        [MinLength(9), StringLength(9), RegularExpression(@"[0][7][7]\d*")]
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
    }
}

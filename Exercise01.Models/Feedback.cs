using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string TechnicalCoverage { get; set; }

        public string? Suggestions { get; set; }
    }
}

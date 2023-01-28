using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public static class TechnicalCoverages
    {
        private static readonly string Excellent = "Excellent";
        private static readonly string Good = "Good";
        private static readonly string Average = "Average";
        private static readonly string Poor = "Poor";

        public static readonly IEnumerable<SelectListItem> TechnicalCoverageDropdown = new[]
        {
            new SelectListItem() { Text = Excellent, Value = Excellent },
            new SelectListItem() { Text = Good, Value = Good },
            new SelectListItem() { Text = Average, Value = Average },
            new SelectListItem() { Text = Poor, Value = Poor },
        };
    }
}

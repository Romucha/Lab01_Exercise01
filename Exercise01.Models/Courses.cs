using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public static class Courses
    {
        private static readonly string ASP_XML = "ASP-XML"; 
        private static readonly string DotNET = "DotNET"; 
        private static readonly string JavaPro = "JavaPro"; 
        private static readonly string Unix = "Unix"; 
        private static readonly string C = "C"; 
        private static readonly string CPlusPlus = "C++";

        public static readonly IEnumerable<SelectListItem> CoursesDropdown = new[]
        {
            new SelectListItem() { Text = ASP_XML, Value = ASP_XML },
            new SelectListItem() { Text = DotNET, Value = DotNET},
            new SelectListItem() { Text = JavaPro, Value = JavaPro},
            new SelectListItem() { Text = Unix, Value = Unix},
            new SelectListItem() { Text = C, Value = C},
            new SelectListItem() { Text = CPlusPlus, Value = CPlusPlus},
        };
    }
}

using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text;

namespace ServicePlanner.Models.ViewModels
{
    public class MethodVM
    {
        public Method Method { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}

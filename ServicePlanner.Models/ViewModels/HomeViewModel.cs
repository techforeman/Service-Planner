using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePlanner.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Method> MethodList { get; set; }
        public IEnumerable<Category> CategoryList { get; set; }
        public IEnumerable<Service> ServiceList { get; set; }
    }
}

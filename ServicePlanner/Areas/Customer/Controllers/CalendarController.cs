using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicePlanner.DataAccess.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ServicePlanner.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CalendarController : Controller
    {
        
        private readonly IUnitOfWork _unityOfWork;
        public CalendarController(IUnitOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

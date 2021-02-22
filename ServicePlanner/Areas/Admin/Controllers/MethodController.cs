using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServicePlanner.DataAccess.Data.Repository.IRepository;
using ServicePlanner.Models.ViewModels;
using ServicePlanner.Utility;

namespace ServicePlanner.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class MethodController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public MethodVM MethVM { get; set; }

        public MethodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }




        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Method.GetAll() });
            //return Json(new { data = _unitOfWork.SP_Call.ReturnList<Category>(SD.usp_GetAllCategory,null)  });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Method.Get(id);
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }

            _unitOfWork.Method.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful." });

        }


        #endregion
    }
}
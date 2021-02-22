using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServicePlanner.DataAccess.Data.Repository.IRepository;
using ServicePlanner.Models;

namespace ServicePlanner.DataAccess.Data.Repository
{
    public class MethodRepository : Repository<Method> , IMethodRepository
    {
        private readonly ApplicationDbContext _db;

        public MethodRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetMethodListForDropDown()
        {
            return _db.Method.Select(i => new SelectListItem()
            {
                Text = i.MethodName,
                Value = i.Id.ToString()
            });
        }

        public void Update(Method method)
        {
            var objFromDb = _db.Method.FirstOrDefault(s => s.Id == method.Id);

            objFromDb.MethodName = method.MethodName;
            objFromDb.NormName = method.NormName;
            objFromDb.Category = method.Category;

            _db.SaveChanges();

        }
    }
}

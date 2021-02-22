using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using ServicePlanner.Models;

namespace ServicePlanner.DataAccess.Data.Repository.IRepository
{
    public interface IMethodRepository : IRepository<Method>
    {
        IEnumerable<SelectListItem> GetMethodListForDropDown();

        void Update(Method method);
    }
}

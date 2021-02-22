﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServicePlanner.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IMethodRepository Method { get; }
        ICategoryRepository Category { get; }
        IFrequencyRepository Frequency { get; }
        IServiceRepository Service { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailsRepository OrderDetails { get; }

        ISP_Call SP_Call { get; }

        IUserRepository User { get; }
        void Save();
    }
}

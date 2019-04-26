using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core;
using System.Data.Entity;

namespace HRMExpress.Data
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}

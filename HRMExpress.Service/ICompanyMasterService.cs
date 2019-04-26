using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;

namespace HRMExpress.Service
{
   public interface ICompanyMasterService
    {
       IQueryable<CompanyMaster> GetCompanyMasters();
       CompanyMaster GetCompanyMaster(long id);        
       void InsertCompanyMaster(CompanyMaster companyMaster);
       void UpdateCompanyMaster(CompanyMaster updateCompanyMaster);
       void DeleteCompanyMaster(CompanyMaster deleteCompanyMaster);
    }
}

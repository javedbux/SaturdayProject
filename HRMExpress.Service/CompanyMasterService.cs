using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;
using HRMExpress.Data;

namespace HRMExpress.Service
{
    public class CompanyMasterService : ICompanyMasterService
    {
        private IRepository<CompanyMaster> companyMasterRepository;
        //private IRepository<Department> departmentRepository;


        public CompanyMasterService(IRepository<CompanyMaster> companyMasterRepository)
        {
            this.companyMasterRepository = companyMasterRepository;
            //this.departmentRepository = departmentRepository;
        }
        public IQueryable<CompanyMaster> GetCompanyMasters()
        {
            return companyMasterRepository.Table;
        }

        public CompanyMaster GetCompanyMaster(long id)
        {
            return companyMasterRepository.GetById(id);
        }

        public void InsertCompanyMaster(CompanyMaster companyMaster)
        {
            companyMasterRepository.Insert(companyMaster);
        }

        public void UpdateCompanyMaster(CompanyMaster companyMaster)
        {
            companyMasterRepository.Update(companyMaster);
        }

        public void DeleteCompanyMaster(CompanyMaster companyMaster)
        {
            companyMasterRepository.Delete(companyMaster);
        }


    }
}

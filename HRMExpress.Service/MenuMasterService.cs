using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;
using HRMExpress.Data;

namespace HRMExpress.Service
{
   public class MenuMasterService : IMenuMasterService
    {
        private IRepository<MenuMaster> menuMasterRepository;
        //private IRepository<Department> departmentRepository;


        public MenuMasterService(IRepository<MenuMaster> menuMasterRepository)
        {
            this.menuMasterRepository = menuMasterRepository;
            //this.departmentRepository = departmentRepository;
        }
        public IQueryable<MenuMaster> GetMenuMasters()
        {
            return menuMasterRepository.Table;
        }
              
         public MenuMaster GetMenuMaster(long id)
        {
            return menuMasterRepository.GetById(id);
        }
         public void InsertMenuMaster(MenuMaster menuMaster)
        {
            menuMasterRepository.Insert(menuMaster);
        }

         public void UpdateMenuMaster(MenuMaster menuMaster)
        {
            menuMasterRepository.Update(menuMaster);
        }

         public void DeleteMenuMaster(MenuMaster menuMaster)
        {
            menuMasterRepository.Delete(menuMaster);
        }


      
    }
    
}

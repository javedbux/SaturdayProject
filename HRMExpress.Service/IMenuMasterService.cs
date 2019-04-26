using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRMExpress.Core.Data;

namespace HRMExpress.Service
{
   
    public interface IMenuMasterService
    {
        IQueryable<MenuMaster> GetMenuMasters();
        MenuMaster GetMenuMaster(long id);
        void InsertMenuMaster(MenuMaster menuMaster);
        void UpdateMenuMaster(MenuMaster updateMenuMaster);
        void DeleteMenuMaster(MenuMaster deleteMenuMaster);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRMExpress.Core.Data
{
   
    public partial class MenuMaster : BaseEntity
    {
        public int ID { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsGroup { get; set; }
        public int GroupID { get; set; }
        public int GroupLevel { get; set; }
        public bool Active { get; set; }
        public string MenuIcon { get; set; }
        public int Sequence { get; set; }
        public string ActionURL { get; set; }        
        public int CompanyID { get; set; }
        public int RoleID { get; set; }
    }
}

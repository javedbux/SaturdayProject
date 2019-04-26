using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class EmployeeDocument
    {
        public int DocID { get; set; }
        public string DocName { get; set; }
        public byte[] Documnet { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime UploadDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}

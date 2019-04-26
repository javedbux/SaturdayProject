using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Document
    {
        public int DocumentID { get; set; }
        public int EmployeeID { get; set; }
        public string DocName { get; set; }
        public string DocPath { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] DocumentDetail { get; set; }
        public string DocumentType { get; set; }
    }
}

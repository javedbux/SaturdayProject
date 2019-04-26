using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class SystemParameter
    {
        public int ParameterID { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}

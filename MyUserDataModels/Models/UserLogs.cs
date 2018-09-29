using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class UserLogs
    {
        public long Id { get; set; }
        public string Operator { get; set; }
        public string OperatorFunc { get; set; }
        public DateTime OperatorDateTime { get; set; }
        public string OperatorDesc { get; set; }
        public string CodeType { get; set; }
        public string Action { get; set; }
    }
}

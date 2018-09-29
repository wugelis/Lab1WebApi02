using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class SystemModule
    {
        public string RoleKey { get; set; }
        public string ModuleName { get; set; }
        public string Desc { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class SystemRole
    {
        public int Id { get; set; }
        public string RoleKey { get; set; }
        public string RoleSysName { get; set; }
        public string Desc { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsEnabled { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class WebApiMethod
    {
        public int Id { get; set; }
        public string RoleKey { get; set; }
        public string ModuleName { get; set; }
        public string MethodName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Desc { get; set; }
    }
}

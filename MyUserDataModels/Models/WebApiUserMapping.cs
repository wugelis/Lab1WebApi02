using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class WebApiUserMapping
    {
        public string UserId { get; set; }
        public string MethodName { get; set; }
        public string RoleKey { get; set; }
        public string ModuleName { get; set; }
    }
}

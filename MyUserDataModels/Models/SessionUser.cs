using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class SessionUser
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

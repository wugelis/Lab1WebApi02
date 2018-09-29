using System;
using System.Collections.Generic;

namespace MyUserDataModels.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ChtName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public string IsAdmin { get; set; }
        public string Remarks { get; set; }
    }
}

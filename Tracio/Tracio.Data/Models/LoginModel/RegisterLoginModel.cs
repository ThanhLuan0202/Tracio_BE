using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.LoginModel
{
    public class RegisterLoginModel
    {
        public int UserId { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? PhoneNumber { get; set; }

        public int? RoleId { get; set; }

        public string? Address { get; set; }

        public DateTime? CreatedTime = DateTime.UtcNow.AddHours(7);

        public DateTime? UpdatedTime { get; set; }

        public int? MemberShipId { get; set; }

        public string? Status = "Active";
    }
}

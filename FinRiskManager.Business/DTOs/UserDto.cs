using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinRiskManager.Business.DTOs
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string TenantId { get; set; } // Çok kiracılı yapı için.
    }
}

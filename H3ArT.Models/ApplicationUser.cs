using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3ArT.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? AvatarImage {  get; set; }
        public bool Gender {  get; set; }
        public int? ShoppingCartId { get; set; } // Nullable int for ShoppingCartId
        public bool Status { get; set; } // Boolean property for Status
    }
}

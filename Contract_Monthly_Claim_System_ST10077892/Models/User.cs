using System;
using System.Collections.Generic;

namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class User
    {
        public int UserID { get; set; }          // Primary Key
        public string? FullName { get; set; }
        public string? Department { get; set; }
        public int RoleID { get; set; }          // Foreign Key to UserRole

        // Navigation property
        public required UserRole Role { get; set; }
    }
}

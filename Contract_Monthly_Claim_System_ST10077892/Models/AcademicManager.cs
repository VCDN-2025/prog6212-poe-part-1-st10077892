using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class AcademicManager : User
    {
        // Navigation property for claims awaiting approval
        public ICollection<Claim> ClaimsToApprove { get; set; } = new List<Claim>();

        // Final approval of claim
        public void FinalApproveClaim(Claim claim)
        {
            if (claim == null) throw new ArgumentNullException(nameof(claim));
            claim.Status = "Final Approved";
            claim.ApprovedDate = DateTime.Now; // if you add such a field
        }

        // Oversee system (could later be extended for reports or monitoring)
        public void OverseeSystem()
        {
            // Example: log oversight action
            Console.WriteLine($"{FullName} is overseeing the system at {DateTime.Now}");
        }
    }
}

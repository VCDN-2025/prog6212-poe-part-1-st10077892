using System;
using System.Collections.Generic;

namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class AcademicManager : User
    {
        public ICollection<Claim> ClaimsToApprove { get; set; } = new List<Claim>();

        public void FinalApproveClaim(Claim claim)
        {
            // Logic for final approval
        }

        public void OverseeSystem()
        {
            // Logic for overseeing the system
        }
    }

}

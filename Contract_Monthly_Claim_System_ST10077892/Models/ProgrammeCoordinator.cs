using System;
using System.Collections.Generic;

namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class ProgrammeCoordinator : User
    {
        public ICollection<Claim> PendingClaims { get; set; } = new List<Claim>();

        public void ReviewClaim(Claim claim)
        {
            // Implementation here
        }

        public void ApproveClaim(Claim claim)
        {
            // Implementation here
        }

        public void RejectClaim(Claim claim)
        {
            // Implementation here
        }
    }

}

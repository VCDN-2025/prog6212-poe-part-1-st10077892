using System;
using System.Collections.Generic;
using System.Linq;

namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class ProgrammeCoordinator : User
    {
        // Claims awaiting review by the coordinator
        public ICollection<Claim> PendingClaims { get; set; } = new List<Claim>();

        // Review claim
        public void ReviewClaim(Claim claim)
        {
            if (claim == null) throw new ArgumentNullException(nameof(claim));
            if (!PendingClaims.Contains(claim))
                PendingClaims.Add(claim);

            claim.Status = "Reviewed by Coordinator";
        }

        // Approve claim
        public void ApproveClaim(Claim claim)
        {
            if (claim == null) throw new ArgumentNullException(nameof(claim));
            if (PendingClaims.Contains(claim))
                PendingClaims.Remove(claim);

            claim.Status = "Coordinator Approved";
            // In a real system: forward to Academic Manager
        }

        // Reject claim
        public void RejectClaim(Claim claim)
        {
            if (claim == null) throw new ArgumentNullException(nameof(claim));
            if (PendingClaims.Contains(claim))
                PendingClaims.Remove(claim);

            claim.Status = "Coordinator Rejected";
        }
    }
}

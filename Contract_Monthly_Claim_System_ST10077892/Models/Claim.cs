namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }          // Primary Key
        public int LecturerID { get; set; }       // Foreign Key
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string? Status { get; set; }        // e.g., Pending, Verified, Approved, Rejected

        // Navigation
        public Lecturer? Lecturer { get; set; }
        public ICollection<SupportingDocument> Documents { get; set; }
    }

}

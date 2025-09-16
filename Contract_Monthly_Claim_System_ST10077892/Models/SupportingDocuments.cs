namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class SupportingDocument
    {
        public int DocumentID { get; set; }     // Primary Key
        public int ClaimID { get; set; }        // Foreign Key
        public string? FilePath { get; set; }    // File storage path
        public DateTime UploadDate { get; set; }

        // Navigation
        public Claim? Claim { get; set; }
    }

}

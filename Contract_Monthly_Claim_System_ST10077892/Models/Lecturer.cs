namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }   // Primary Key
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }

        // Relationships
        public ICollection<Claim> Claims { get; set; }
    }

}

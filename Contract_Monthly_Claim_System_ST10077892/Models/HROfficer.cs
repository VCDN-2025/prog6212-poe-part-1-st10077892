using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contract_Monthly_Claim_System_ST10077892.Models
{
    public class HROfficer : User
    {
        // Navigation property for lecturers HR manages
        public ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

        // Add a lecturer
        public void AddLecturer(Lecturer lecturer)
        {
            if (lecturer == null) throw new ArgumentNullException(nameof(lecturer));
            Lecturers.Add(lecturer);
        }

        // Update lecturer details
        public void UpdateLecturer(Lecturer lecturer)
        {
            if (lecturer == null) throw new ArgumentNullException(nameof(lecturer));
            // Simple placeholder: replace existing lecturer with updated one
            var existing = Lecturers.FirstOrDefault(l => l.LecturerID == lecturer.LecturerID);
            if (existing != null)
            {
                existing.FullName = lecturer.FullName;
                existing.Email = lecturer.Email;
                existing.Department = lecturer.Department;
            }
        }

        // Generate HR reports (stub)
        public string GenerateReports()
        {
            return $"HR Officer {FullName} generated report at {DateTime.Now}";
        }

        // Manage HR-level claim approval
        public void ManageClaimApproval(Claim claim)
        {
            if (claim == null) throw new ArgumentNullException(nameof(claim));
            claim.Status = "HR Approved";
        }
    }
}

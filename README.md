📌 Contract Monthly Claim System (CMCS)

The Contract Monthly Claim System (CMCS) is a .NET Core prototype designed to streamline the process of submitting and approving monthly claims for Independent Contractor (IC) lecturers. This project was developed as part of the PROG6212 Portfolio of Evidence (PoE) to demonstrate skills in .NET GUI development, UML modeling, and project planning.

🚀 Features (Prototype Stage)

Lecturer:

Submit claims (hours worked × hourly rate).

Upload supporting documents.

View claim history and statuses.

Programme Coordinator:

Review and approve/reject lecturer claims.

Forward approved claims to Academic Manager.

Academic Manager:

Provide final approval for claims.

Oversee system processes and approvals.

HR Officer:

Manage lecturer records.

Generate reports and summaries of claims.

🛠️ Technologies Used

.NET Core 6.0+

C#

Entity Framework Core (EF Core) for database modeling

WPF / ASP.NET Core MVC for GUI prototype

UML Class Diagrams (designed in draw.io or Visual Studio tools)

📊 Database Entities

Lecturer (LecturerID, FullName, Email, Department)

Claim (ClaimID, LecturerID, HoursWorked, HourlyRate, SubmissionDate, Status)

SupportingDocument (DocumentID, ClaimID, UploadDate, FilePath)

UserRole (RoleID, RoleName)

📐 UML Overview

The UML class diagram includes:

Base class User with derived roles: Lecturer, ProgrammeCoordinator, AcademicManager, HROfficer.

Relationships:

One Lecturer → Many Claims.

One Claim → Many Supporting Documents.

One UserRole → Many Users.

(See /UML/CMCS_ClassDiagram.png for the full diagram.)

📅 Project Plan

The project was developed in four phases:

Initiation – Requirements analysis & setup.

Design – UML class diagram, database schema, and GUI wireframes.

Prototype Development – Models and GUI mockups (non-functional).

Documentation – Final report with design explanations, project plan, and assumptions.

✨ Future Improvements

Implement authentication and authorization (role-based access).

Add database persistence with EF Core migrations.

Develop real claim approval workflows.

Integrate reporting and document storage.

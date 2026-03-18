# Employee Attendance System (EAS)

A Windows Forms desktop application for managing employee leave requests 
in a company environment. Built as part of a complete software engineering 
process — from formal requirements specification to working implementation.

## Project Background

This project was developed following a full SDLC process:

- **Requirements phase** — IEEE 830-compliant Software Requirements 
  Specification (SRS) defining 8 functional requirements, user roles, 
  constraints, and wireframes
- **Design phase** — Software Design Specification including UML use case, 
  sequence, activity, and class diagrams for core use cases
- **Implementation phase** — Working C# Windows Forms application with 
  SQL database backend and repository pattern architecture

## Features

**Employee role**
- Login with username and password
- Create leave requests (annual leave, day off, business trip, 
  training, sick leave)
- View own request history and current status

**Manager role**
- View all submitted requests
- Approve or reject requests
- Filter and search requests by status in real time
- Edit existing request details

## Tech Stack

- **Language** — C# (.NET Framework 4.8)
- **UI** — Windows Forms
- **Database** — SQL (via university DBLayer library)
- **Architecture** — Repository pattern (KorisniciRepository, 
  ZahtjeviRepository)
- **IDE** — Visual Studio

## Project Structure
```
Employee_Attendance_System/
├── Forms/
│   ├── FrmPrijava.cs          # Login form
│   ├── FrmPrikazZahtjeva.cs   # Main request list view
│   ├── FrmStvaranjeZahtjeva.cs # Create new request
│   └── FrmIzmjenaZahtjeva.cs  # Edit existing request
├── Models/
│   ├── Korisnici.cs           # User model
│   └── Zahtjevi.cs            # Request model
└── Program.cs                 # Entry point
```

## Documentation

Full SRS and Software Design Specification (including all UML diagrams 
and wireframes) are available in the Wiki section of this repository.

## Academic Context

Developed at the Faculty of Organization and Informatics (FOI), 
University of Zagreb, as part of the Information and Business Systems 
undergraduate programme.

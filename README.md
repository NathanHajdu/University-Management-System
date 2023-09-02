# University System

University System is a Windows Forms application designed for managing student and instructor data within a university. It provides a user-friendly interface to access, search, and display information about students and instructors.

## Features

### Main Form

The Main Form serves as the landing page for the University System. It allows users to navigate to the Student and Instructor directories with the click of a button. The form is centered on initialization.

### Student Directory Form

The Student Directory Form enables users to search for students by their Student ID (SID). When a valid SID is entered, the form displays a table with the following details:

- Course ID (CID)
- Course Title
- Units
- Location
- Instructor ID (IID)

A dynamic label above the grid shows the student's name based on the search. The form also includes the following functionality:

- **Back to Main**: Closes the active session and returns to the Main Form.
- **Reset**: Clears the SID field, sets the name label to empty, and hides unnecessary elements.

Validation is in place to handle empty SID fields and incorrect SIDs.

### Instructor Directory Form

The Instructor Directory Form operates similarly to the Student Directory. Users can search for instructors by Instructor ID (IID). Upon a valid IID entry, the form displays a table with the following instructor details:

- Rank
- Department (Dept)
- Course ID (CID)
- Course Title
- Units
- Semester

The form also includes options to go back to the Main Form and reset the form fields.

## Usage

To use the University System, follow these steps:

1. Open the application.
2. Use the Main Form to navigate to either the Student Directory or Instructor Directory.
3. Search for students or instructors using their respective IDs.
4. View the results in a tabular format.
5. Optionally, return to the Main Form or reset the form for a new search.

## Technologies

- C# (.NET Framework)
- SQL Server (for database interaction)
- Windows Forms

## Installation

1. Clone this repository to your local machine.
2. Open the project in Visual Studio or your preferred C# development environment.
3. Build and run the application.

## Database Configuration

The application requires a connection to a SQL Server database. Configure the database connection string in the relevant sections of the code where indicated.

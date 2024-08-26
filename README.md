# MyOrganizerApplication

## Overview

This is a Windows Forms-based personal organizer application developed in C#. The application is designed to be used by multiple users and includes the following modules:

- **User Management**: Manage users with different roles (Admin, User, Part-Time User).
- **Phonebook**: Store and manage contacts with detailed information.
- **Notes**: Create and manage personal notes.
- **Personal Information**: View and edit user profiles, including a photo upload feature.
- **Reminders**: Set and manage reminders with specific dates and times.
- **Salary Calculator**: Calculate and store minimum salary information based on specific criteria.

## Features

### User Management
- The first user to register becomes the system administrator.
- Admins can change the role of other users.
- Supports three user roles: Admin, User, and Part-Time User.
- Admin users can manage the user list, add new users, update or delete users, and download user data.

### Phonebook
- Users can add, update, delete, and list contacts.
- Data is stored in a `phonebook.csv` file.
- Fields include Name, Surname, Phone Number, Address, Description, and E-mail.
- The phone number is formatted as (555) 555-5555.
- E-mail field validation using regular expressions.

### Notes
- Simple note-taking module where users can add, update, delete, and list notes.
- Data is stored in a `notes.csv` file.

### Personal Information
- Users can view and update their profile information.
- Profile fields include Name, Surname, Username, Phone Number, Address, E-mail, Password, and Photo.
- The photo is stored in the CSV file as a base64 string.
- Supports undo (CTRL-Z) and redo (CTRL-Y) operations for field changes.

### Reminders
- Users can create, update, delete, and list reminders.
- Reminders are categorized as either Meetings or Tasks.
- Each reminder includes a Date, Time, Summary, and Description.
- The reminder summary is displayed on the active window header, and the window shakes for two seconds when a reminder is triggered.

### Salary Calculator
- Calculates the user's minimum salary based on their education, experience, family status, and foreign language skills.
- The salary for part-time users is automatically reduced by 50%.
- The calculated salary is displayed on the user profile page and stored in the user's data.

## Usage

1. **Login**: Users must log in using their username and password. The first registered user will have admin privileges.
2. **Navigation**: The application provides a main menu for accessing different modules such as the Phonebook, Notebook, Reminder, Salary Calculator, and User Management (for admins).
3. **User Management**: Admin users can access the user management screen to manage other users' accounts.
4. **Phonebook**: Add, update, or delete contacts from the phonebook. Contacts can be searched by name or surname.
5. **Notes**: Use the notebook module to add, update, or delete personal notes.
6. **Reminders**: Set reminders for meetings or tasks, and manage them using the reminder module.
7. **Salary Calculation**: Use the salary calculator to determine the minimum salary based on your profile's specific parameters.

## Files

- `phonebook.csv`: Stores phonebook contact information.
- `notes.csv`: Stores notes created by the user.
- `user.csv`: Stores user information including their role and profile details.
- `reminders.csv`: Stores reminder data for each user.
- `salary.csv`: Stores calculated salary information for each user.

## Setup and Installation

1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Build the project to restore any missing NuGet packages.
4. Run the application from Visual Studio.

## Project Structure

- `Forms/`: Contains the main forms for each module.
- `Helpers/`: Includes helper classes and functions for various tasks like file handling, validation, and formatting.
- `Models/`: Contains model classes that represent the data structures used in the application.
- `Properties/`: Stores project properties and resources.

## Contribution Guidelines

1. Ensure that your code follows the project's coding standards.
2. Test your changes before submitting a pull request.
3. Update the README and any relevant documentation as needed.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Contact

For any inquiries, please contact the project contributors at [your-email@example.com].

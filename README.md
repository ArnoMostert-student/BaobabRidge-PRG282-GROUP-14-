# Baobab Ridge Wildlife Rehabilitation Records System

## Group Members

| Name                    | Student Number | Feature Built       |
|-------------------------|----------------|---------------------|
| Arno Mostert            | 603196         | Foundation & View   |
| Gadil Mureithi Gitari   | 603806         | Add                 |
| Akani Thinetho Baloyi   | 604040         | Update              |
| Tlotlego Mahomed        | 603831         | Delete & Summary    |

## Project Information

**Module:** Programming 2782 (PRG2782)  
**Project:** Project 2026  
**Application Type:** C# Windows Forms Desktop Application  
**Framework:** .NET 8.0 or newer  
**Data Storage:** Plain text files  
**Version Control:** Git and GitHub

## Project Overview

The Baobab Ridge Wildlife Rehabilitation Records System is a desktop application developed for a fictional wildlife rehabilitation centre that treats injured and orphaned wild animals.

The purpose of the application is to replace manual record-keeping methods, such as clipboards and spreadsheets, with a centralised digital system. It allows staff to manage animal records, monitor recovery progress, determine appropriate housing units and generate summary reports.

The application automatically calculates each animal's status and housing unit based on the recovery score provided by the veterinarian.

## Features

### 1. Add Animal
- Add new animal records using a form.
- Validate animal IDs, names, species, ages and recovery scores.
- Prevent duplicate animal IDs.
- Automatically calculate the animal's status and housing unit.
- Save new records to `animals.txt`.

### 2. View Animals
- Display all valid animal records in a DataGridView.
- Show the animal ID, name, species, age, recovery score, status and housing unit.
- Load records automatically when the application starts.
- Refresh the grid after adding, updating or deleting records.
- Skip malformed records when loading data.

### 3. Update Animal
- Select an animal from the grid or search by animal ID.
- Load the selected animal's details into the input fields.
- Update the animal's information while keeping its ID unchanged.
- Recalculate the status and housing unit after saving changes.

### 4. Delete Animal
- Select an animal record from the grid.
- Display a confirmation message before deletion.
- Remove the selected record from `animals.txt` after confirmation.

### 5. Summary Report
- Calculate the total number of animals.
- Calculate the average age and recovery score.
- Count the animals in each recovery status.
- Display the results in the application.
- Generate a `summary.txt` report containing the calculated statistics.

## Data Storage

The application uses plain text files for data storage, as required by the project specification. No database is used.

### `animals.txt`

Stores animal records, with one animal per line. The fields are separated by the pipe character (`|`) in the following order:

`Animal ID|Name|Species|Age|Recovery Score|Status|Housing Unit`

Example:

`WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp`

The file is stored in the same directory as the running application executable.

## Technologies Used

- **C#:** Application logic and data processing.
- **Windows Forms:** Desktop user interface.
- **.NET 8.0 or newer:** Application framework.
- **Text Files:** Persistent storage of animal records and summary reports.
- **Git:** Source code version control.
- **GitHub:** Remote repository, collaboration, branches and pull requests.
- **Visual Studio:** Development environment.
  
## How to Build and Run

### Prerequisites

- Windows operating system.
- Visual Studio with the .NET desktop development workload installed.
- .NET 8.0 SDK or a compatible newer version.
- Git (optional if downloading the repository as a ZIP file).

### Steps

1. Clone the repository from GitHub:

   ```bash
   git clone https://github.com/ArnoMostert-student/BaobabRidge-PRG282-GROUP-14-.git
   ```

2. Open the cloned project folder in Visual Studio.

3. Open the solution file (`.sln`). If the project does not contain a solution file, open the `.csproj` file instead.

4. Ensure that `animals.txt` is included in the project and configured to copy to the output directory if it does not already exist there.

5. Build the solution using **Build > Build Solution**.

6. Run the application using **F5** or **Start** in Visual Studio.

The application should load the animal records and display them in the main form.

## Error Handling and Validation

The application is designed to validate user input and handle file-related errors without unexpectedly terminating.

- Required fields are checked before records are saved.
- Animal IDs must follow the required format and be unique.
- Age and recovery score must be whole numbers between 0 and 100.
- Status and housing unit are calculated automatically.
- Invalid records in the data file are skipped during loading.
- File access and permission errors are handled with user-friendly messages.

## Known Limitations

- The application is designed for a Windows desktop environment.
- Animal records are stored in a plain text file rather than a database.
- The application is intended for the requirements of the PRG2782 academic project.
- Data integrity depends on the correct format and accessibility of the text files.

## Repository

GitHub: https://github.com/ArnoMostert-student/BaobabRidge-PRG282-GROUP-14-

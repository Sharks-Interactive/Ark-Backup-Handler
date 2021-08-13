# Ark Backup Handler
This repository contains everything relevant to the Ark Backup Handler windows app for backing up server files for Ark: Survival Evolved.

## Resources/
  - Contains the source for images
  
Project created and maintained by Sharks Interactive.

## Building the app:
### Prerequisites:
  - Ensure you have Visual Studio 2029 installed and up to date
  - Ensure you have the 'Desktop Development with .NET' workload installed
  
### Setup:
  - Clone (``git clone https://github.com/Sharks-Interactive/Ark-Backup-Handler.git``) the repo to a local folder
  - Open up Visual Studio, hit the option to open a project, and locate the sln in the app/form folder of this repo on your drive
  - Hit the green arrow to start debugging and VS will build the app and run it
  
### Developing:
  - Form1.cs is the entrypoint
  - Commit to ``staging`` and pr to ``prod`` for changes

### Code Style:
  - Underscores and camelCase must preceed private members eg: ``private bool _correctUse;``
  - Upercase and no preceeding letter for public members eg: ``public bool CorrectUse;``
  - Protected members should follow the private member procedure
  - Functions should start with uppercase
  

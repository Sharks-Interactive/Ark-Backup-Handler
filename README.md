
#  Ark Backup Handler

This repository contains everything relevant to the Ark Backup Handler windows app for backing up server files for Ark: Survival Evolved.

![Social Icon with Ark Logo and rewind arrow overlayed](https://raw.githubusercontent.com/Sharks-Interactive/Ark-Backup-Handler/bfee4b55c9e36a806b61f339c67057bb1c4dffe0/.branding/Ark%20Backup%20Handler%20Social%20Card.png)

##  Contents

- [About](#About)
- [Features](#Features)
- [Contributing](#Contributing)
- [Acknowledgements](#Acknowledgements)

Project created and maintained by [Sharks Interactive](https://sharksinteractive.net).

## About
Ark Backup Handler is the only server backup management tool that I can find that uses a graphical user interface so as to be user friendly. Many others utilise great technologies like Docker or simply the command line at the expense of inexperienced or non programmers not being able to use them. Ark Backup Handler solves all these issues while remaining flexible and performant enough to be the preferred choice for programmers and normal people alike.

## Features
### Automatically Backup Server Saves
Configure time between backups, backup locations, and max backups.
### Separately Backup Transfer/Cluster Data
Transfer data is important to players and all too often player's lose items in transport. Separately choose time between backups for cluster data so you can always rollback.
### Run In the Background
Ark Backup Handler's minimize to tray features allows it to neatly tuck away, preventing it from cluttering your screen and allowing it to use even fewer system resources while still being one click away.
### Performance First
Ark Backup Handler was built from the ground up with performance in mind - we know that players expect your server to be running at it's best which means extra applications hogging ram or cpu have to be avoided.
### Manual Backups
Use the simple interface to quickly create a manual backup to mark a big moment or move for your server. Manual Backups are never overwritten.
### Simple Overview of Backups
Uh oh. Something's gone wrong? Switch to the 'revert' tab for an overview of every backup created, sorted by milestone, initiator, contents and more! Need to save some space? Delete a backup from here too!
### Easily Revert
Two clicks and you can choose to revert just transfer data, save data, config data or all data to the chosen backup date. A backup of the current point in time will be automatically created!
### Neat File Structure
Have trust issues? Prefer to revert manually? No problem! Ark Backup Handler neatly creates elegant folders to organize all of your backups on your hard drive.
### And more...
 - Automatically updates Message of the Day with custom fields like Date/Time and last backup
 - Command Line Tool (Coming Soon)
 - Easy to use: Tooltips for all controls
 - Fast: ABH is a native .NET core application
 - 100% Free. No premium accounts, no tracking data sent to the cloud, all open source and transparent
 - Performant: Uses less than 20mb ram when minimized and 0% cpu when idle
 - Configurable: Slew of options allow you to customize Ark Backup Handler to your application
 - Supports all PC versions of Ark: Survival Evolved and it's dedicated server redistributable

#### Learn More:
##### Command Line Tool (Coming Soon)
Are you a programmer? Do you prefer further control over Ark Backup Handler? Even better performance? Do you run your server in a headless environment? If you answered yes to any of these questions not only are you crazy but you also could benefit from the Ark Backup Handler CLI!
##### Automatic Message of the Day
Ever wished you could include things like the date/time in your MoD and have it automatically update? Wish no more... Easily configure a custom MoD with dynamic fields like the current date, or the last time the server backed up!

##  Contributing

###  Prerequisites:

- Ensure you have Visual Studio 2022 (Recommended) or 2019 installed and up to date

- Ensure you have the 'Desktop Development with .NET' workload installed

###  Setup:

- Clone (``git clone https://github.com/Sharks-Interactive/Ark-Backup-Handler.git``) the repo to a local folder

- Open up Visual Studio, hit the option to open a project, and locate the sln in the root folder of this repo on your drive

- Hit the green arrow to start debugging and VS will build the app and run it

###  Developing:
Project: Ark Backup Handler
- Program.cs is the entrypoint
- Window.cs handles all UI
- Window.Events.cs handles UI callbacks

Project: Ark Backup Handler.Tests
- All unit tests are located here

Project SharksControls
- Custom components

#### Commit to ``staging`` and pr to ``prod`` for changes

###  Code Style:

- Underscores and camelCase must precede private members eg: ``private bool _correctUse;``

- Uppercase and no preceding letter for public members eg: ``public bool CorrectUse;``

- Protected members should follow the private member procedure

- Functions should start with uppercase


## Acknowledgements
ReadMe layout taken from/inspired by the wonderful [Lively Wallpaper](https://github.com/rocksdanister/lively/blob/dev-v1.0-fluent-netcore/README.md)

# Mabi Launch
Supposed to be a fancy Mabi launcher

Its meant to be used with Abyss/Tiara/Frontend bc it will launch HSLaunch for you, and Direct Launch won't run w/o it. Honestly, you could just use a bat file for this, but I wanted something nice.

This needs .NET Framework 4 to run --> https://www.microsoft.com/en-us/download/details.aspx?id=17851

#### Features
- Meant to look like those old Ragnarok Online Private Server Launchers
- Launches Mabi Directly w/o the official launcher + HSLauncher from Abyss
- Launches the Official Mabi Launcher for updates
- Automaticly logs you in with `mlog.exe` and `mlog.ini` (optional)
- Literally a Blingee version of the Launcher... featuring The Official Mabi Launcher from the Nexon NA series.

#### Upcoming death
When will they happen? We may never know.
- Pull updates from Nexon servers and patch directly
- Frontend/Tiara support (Launches Frontend from the program if you have it, Doubt this is needed)
- Checklist for Abyss.ini (Doubt this is really needed either)
- A Better Layout.


## mlog.exe
Uses AutoIt to input your information in the mabi login screen for you. You can modify your details in the INI file. If you just want something to put in your info automatically, just pull out `mlog.exe` and `mlog.ini`. If you don't want them to pop up with the launcher, just delete them.

Note: You MUST focus Mabi while waiting for the script to run. Otherwise, it'll type into whatever window you have up.

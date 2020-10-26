; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Mission Planner by SBY"
#define MyAppVersion "1.3.72"
#define MyAppPublisher "SBY TECH CHILE SPA"
#define MyAppURL "http://www.sbytech.cl"
#define MyAppExeName "MissionPlanner.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{99871EFA-C8C8-4E58-88C7-B494C797371E}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}

AppCopyright=Copyright (C) 2020 - SBY TECH CHILE SpA.

DisableProgramGroupPage=yes
LicenseFile=E:\Temp\MissionPlanner\MissionPlanner\COPYING.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=D:\
OutputBaseFilename=Mission Planner - Install
;SetupIconFile=E:\Temp\MissionPlanner\MissionPlanner\mpdesktop150.png
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: 

[Files]
Source: "E:\Temp\MissionPlanner\MissionPlanner\bin\Release\net461\MissionPlanner.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Temp\MissionPlanner\MissionPlanner\bin\Release\net461\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\Drivers\DPInstx64.exe"; StatusMsg: "Installing Drivers..."; 
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


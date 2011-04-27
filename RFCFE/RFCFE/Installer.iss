; Installer script for Robust File Copy Front End
; Copyright (C) 2010-2011 Almir Dzinovic <almir@dzinovic.net>
;
; This program is free software; you can redistribute it and/or modify it under
; the terms of the GNU General Public License as published by the Free Software
; Foundation; either version 3 of the License, or (at your option) any later version.
;
; This program is distributed in the hope that it will be useful, but WITHOUT
; ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
; FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
;
; Get the full text of the GPL here: http://www.gnu.org/licenses/gpl.txt

[Setup]
AppName=Robust File Copy Front End
AppVerName=Robocopy Front End
AppVersion=1.1.0.0
AppPublisher=Almir Dzinovic
AppPublisherURL=http://www.dzinovic.net/
DefaultDirName={pf}\Robocopy Front End
DefaultGroupName=Robocopy Front End
AllowNoIcons=yes
SetupIconFile=RFCFE.ico
UninstallDisplayIcon={app}\RFCFE.exe
Compression=lzma
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "bin\x64\Debug\RFCFE.exe"; DestDir: "{app}"; Check: Is64BitInstallMode; Flags: promptifolder replacesameversion restartreplace uninsrestartdelete
Source: "bin\Debug\RFCFE.exe"; DestDir: "{app}"; Check: not Is64BitInstallMode; Flags: promptifolder replacesameversion restartreplace uninsrestartdelete
Source: "bin\Debug\RFCFE.exe.config"; DestDir: "{app}"; Flags: promptifolder replacesameversion restartreplace uninsrestartdelete
Source: "User Manual.pdf"; DestDir: "{app}"; Flags: isreadme restartreplace uninsrestartdelete
Source: "License.txt"; DestDir: "{app}"; Flags: restartreplace uninsrestartdelete

[Icons]
Name: "{group}\Robocopy Front End"; Filename: "{app}\RFCFE.exe"
Name: "{group}\Robocopy Front End Manual"; Filename: "{app}\User Manual.pdf";
Name: "{commondesktop}\Robocopy Front End"; Filename: "{app}\RFCFE.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Robocopy Front End"; Filename: "{app}\RFCFE.exe"; Tasks: quicklaunchicon

[UninstallDelete]
Type: filesandordirs; Name: "{localappdata}\RFCFE"


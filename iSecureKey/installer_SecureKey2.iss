; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Secure Key"
#define MyAppVersion "1.0"
#define MyAppPublisher "Msc-soft.com"
#define MyAppURL "https://msc-soft.com/"
#define MyAppExeName "iSecureKey.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{18EC3D6D-53CF-4944-B5FE-7D89AE31D416}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\SecureKey
DefaultGroupName={#MyAppName}
OutputDir=C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\output
OutputBaseFilename=setup_SecureKey
SetupIconFile=C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\images\key.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\iSecureKey.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\MetroFramework.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\MetroFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\MetroFramework.Fonts.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\WolfSslNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\dlls\wolfssl.dll"; DestDir: "{app}\dlls"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Dirs]
Name: "{app}\files" ; Permissions: everyone-full

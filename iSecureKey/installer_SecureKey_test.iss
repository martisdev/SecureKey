; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Secure Key"
#define MyAppVersion "1.0"
#define MyAppPublisher "Msc-Soft"
#define MyAppURL "https://msc-soft.com/"
#define MyAppExeName "iSecureKey.exe"
#define VCLStylesSkinPath "{localappdata}\VCLStylesSkin"
[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B9DB3F4D-C28B-45F1-92AF-969CD57C579B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
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
Source: "C:\Program Files (x86)\The Road To Delphi\VCL Styles Inno\VclStylesinno.dll"; DestDir: {#VCLStylesSkinPath}; Flags: uninsneveruninstall
Source: "C:\Program Files (x86)\The Road To Delphi\VCL Styles Inno\Styles\OrangeGraphite.vsf"; DestDir: {#VCLStylesSkinPath}; Flags: uninsneveruninstall

Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\iSecureKey.exe"; DestDir: {#VCLStylesSkinPath}; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\MetroFramework.Design.dll"; DestDir: {#VCLStylesSkinPath}; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\MetroFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\MetroFramework.Fonts.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\WolfSslNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\MSC Source\Windows_APP\iSecureKey\iSecureKey\bin\Release\dlls\wolfssl.dll"; DestDir: "{app}\dlls"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[code]
// Import the LoadVCLStyle function from VclStylesInno.DLL
procedure LoadVCLStyle(VClStyleFile: String); external 'LoadVCLStyleW@files:VclStylesInno.dll stdcall setuponly';
procedure LoadVCLStyle_UnInstall(VClStyleFile: String); external 'LoadVCLStyleW@{#VCLStylesSkinPath}\VclStylesInno.dll stdcall uninstallonly';
// Import the UnLoadVCLStyles function from VclStylesInno.DLL
procedure UnLoadVCLStyles; external 'UnLoadVCLStyles@files:VclStylesInno.dll stdcall setuponly';
procedure UnLoadVCLStyles_UnInstall; external 'UnLoadVCLStyles@{#VCLStylesSkinPath}\VclStylesInno.dll stdcall uninstallonly';

 
function InitializeSetup(): Boolean;
begin
  ExtractTemporaryFile('OrangeGraphite.vsf');
  LoadVCLStyle(ExpandConstant('{tmp}\OrangeGraphite.vsf'));
  Result := True;
end;
 
procedure DeinitializeSetup();
begin
  UnLoadVCLStyles;
end;

function InitializeUninstall: Boolean;
begin
  Result := True;
  LoadVCLStyle_UnInstall(ExpandConstant('{#VCLStylesSkinPath}\OrangeGraphite.vsf'));
end;

procedure DeinitializeUninstall();
begin
  UnLoadVCLStyles_UnInstall;
end;

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Dirs]
Name: "{app}\files" ; Permissions: everyone-full
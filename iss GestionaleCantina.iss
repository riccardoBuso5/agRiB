
; Script Installer per agRiB
; Creato con Inno Setup 6

#define MyAppName "agRiB"
#define MyAppVersion "2.0.0"
#define MyAppPublisher "Azienda Vinicola"
#define MyAppExeName "agRiB.exe"

[Setup]
; Genera un nuovo GUID usando Tools -> Generate GUID in Inno Setup
AppId={{A1B2C3D4-E5F6-4A5B-8C9D-E1F2A3B4C5D6}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=Installer
OutputBaseFilename=agRiB_Setup_v{#MyAppVersion}
Compression=lzma
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=admin

[Languages]
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"

[Tasks]
Name: "desktopicon"; Description: "Crea un'icona sul desktop"; GroupDescription: "Icone aggiuntive:"

[Files]
; CORREZIONE: Percorso aggiornato per .NET 9 e Windows 8.0
Source: "bin\Release\net9.0-windows8.0\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; File manuale dalla cartella corretta
Source: "manuale\manuale.pdf"; DestDir: "{app}\manuale"; Flags: ignoreversion skipifsourcedoesntexist
Source: "manuale\manuale.md"; DestDir: "{app}\manuale"; Flags: ignoreversion skipifsourcedoesntexist
Source: "LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Manuale Utente"; Filename: "{app}\manuale\manuale.pdf"; Check: FileExists(ExpandConstant('{app}\manuale\manuale.pdf'))
Name: "{group}\Configurazione Database"; Filename: "notepad.exe"; Parameters: """{app}\paswd.txt"""
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Avvia {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
var
  DatabasePage: TInputQueryWizardPage;

procedure InitializeWizard;
begin
  DatabasePage := CreateInputQueryPage(wpSelectDir,
    'Configurazione Database', 'Parametri MySQL',
    'Inserire i parametri di connessione al database MySQL:');
  
  DatabasePage.Add('Server:', False);
  DatabasePage.Add('Database:', False);
  DatabasePage.Add('Username:', False);
  DatabasePage.Add('Password:', True);
  DatabasePage.Add('Porta:', False);
  
  // Valori predefiniti
  DatabasePage.Values[0] := 'localhost';
  DatabasePage.Values[1] := 'cantina';
  DatabasePage.Values[2] := 'root';
  DatabasePage.Values[3] := '';
  DatabasePage.Values[4] := '3306';
end;

procedure CurStepChanged(CurStep: TSetupStep);
var
  ConfigContent: String;
begin
  if CurStep = ssPostInstall then
  begin
    // Crea il file paswd.txt con i parametri inseriti
    ConfigContent := 'server=' + DatabasePage.Values[0] + 
                     ';database=' + DatabasePage.Values[1] + 
                     ';user id=' + DatabasePage.Values[2] + 
                     ';password=' + DatabasePage.Values[3] + 
                     ';port=' + DatabasePage.Values[4] + 
                     ';CharSet=utf8;';
    SaveStringToFile(ExpandConstant('{app}\paswd.txt'), ConfigContent, False);
  end;
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  MsgBox('Questo installer installerà agRiB - Gestionale Cantina.' + #13#10#13#10 + 
         'Requisiti:' + #13#10 + 
         '- MySQL Server 5.7 o superiore' + #13#10 + 
         '- Windows 8 o superiore' + #13#10 +
         '- .NET 9.0 Runtime', 
         mbInformation, MB_OK);
end;
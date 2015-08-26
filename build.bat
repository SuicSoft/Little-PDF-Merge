@echo off
for %%* in (.) do title Building %%~nx*
for %%* in (.) do echo Building %%~nx* ...
msbuild /property:Configuration=Release "Little's PDF Merge.sln" /maxcpucount:%NUMBER_OF_PROCESSORS%
for %%* in (.) do echo Creating Shortcut For %%~nx* ...
Set MyFile=%~dp0\Windows Desktop\Little's PDF Merge Windows\bin\Release\LPM.Windows.exe
Set ShorcutName=Little's PDF Merge
(
echo Call Shortcut("%MyFile%","%ShorcutName%"^)
echo Sub Shortcut(ApplicationPath,Nom^)
echo    Dim objShell,DesktopPath,objShortCut,MyTab
echo    Set objShell = CreateObject("WScript.Shell"^)
echo    MyTab = Split(ApplicationPath,"\"^)
echo    If Nom = "" Then
echo    Nom = MyTab(UBound(MyTab^)^)
echo    End if
echo    DesktopPath = objShell.SpecialFolders("Desktop"^)
echo    Set objShortCut = objShell.CreateShortcut(DesktopPath ^& "\" ^& Nom ^& ".lnk"^)
echo    objShortCut.TargetPath = Dblquote(ApplicationPath^)
echo    objShortCut.Save
echo End Sub
echo Function DblQuote(Str^)
echo    DblQuote = Chr(34^) ^& Str ^& Chr(34^)
echo End Function
@echo off
del source\*.* /S /F /Q
mkdir source
copy "..\bin\release\KidzAlphabet.exe" source
copy "..\bin\release\AxInterop.WMPLib.dll" source
copy "..\bin\release\Interop.WMPLib.dll" source
mkdir source\gambar
copy "..\bin\release\gambar\*.*" "source\gambar" 
mkdir source\suara
copy "..\bin\release\suara\*.*" "source\suara" 



!include "nsProcess.nsh"
OutFile "Setup.exe"

installDir "$PROGRAMFILES\Swdev Bali\KidzAlphabet"
!define shortcutDir "$SMPROGRAMS\KidzAlphabet"
RequestExecutionLevel admin


section
	SetShellVarContext all
	setOutPath $INSTDIR
	File /r "source\*"
	writeUninstaller $INSTDIR\uninstaller.exe
	CreateDirectory "${shortcutDir}" 
	createShortCut "${shortcutDir}\Kidz Alphabet.lnk" "$INSTDIR\KidzAlphabet.exe"
	createShortCut "${shortcutDir}\Uninstall.lnk" "$INSTDIR\uninstaller.exe"
sectionEnd
	section "Uninstall"
	SetShellVarContext all
	delete "$INSTDIR\uninstaller.exe"
	RMDir /r "$INSTDIR"
	RMDir /r "${shortcutDir}"
sectionEnd
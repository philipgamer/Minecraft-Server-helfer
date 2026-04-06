@echo off
title Minecraft Server Installer
color 0f

:start
echo Hallo!
timeout /t 1 >nul
echo Du willst einen Minecraft Server erstellen?
timeout /t 1 >nul
echo Dann erstellen wir erst mal einen Ordner.
echo.
set /p name=Wie soll dein Minecraft Server heissen?: 

mkdir "%name%"
echo Ordner "%name%" wurde erstellt.
Pause

echo.
echo Jetzt brauchst du die Server-Datei (Jar).
timeout /t 1 >nul
echo Ich empfehle PaperMC.
timeout /t 1 >nul
echo Achtung: Ich oeffne jetzt deinen Browser...
timeout /t 1 >nul
start https://papermc.io/downloads/paper
Pause

cls
echo === SCHRITT 2 ===
echo Kopiere die runtergeladene Datei JETZT in den Ordner "%name%".
echo.
pause

echo Erstelle die Start-Datei...
:: WICHTIG: Keine Anführungszeichen am Anfang/Ende der Zeile!
echo java -Xmx4G -Xms4G -jar paper.jar nogui > "%name%\start_server.bat"
echo pause >> "%name%\start_server.bat"

cls
echo === FAST FERTIG ===
echo Gehe in den Ordner "%name%".
echo Benenne deine runtergeladene Datei in "paper.jar" um.
echo (Dann musst du im Code nichts mehr aendern!)
echo.
echo Starte danach die "start_server.bat" per Doppelklick.
Pause

:ram
cls
echo === RAM Check ===
echo Achtung! Das ist wichtig, damit dein Server nicht laggt! 
echo Wie viel RAM hat dein PC INSGESAMT? (Nur die Zahl schreiben, z.B. 16) 
set /p wahl=RAM in GB: 

if "%wahl%"=="4" goto 4GB
if "%wahl%"=="8" goto 8GB
if "%wahl%"=="16" goto 16GB
if "%wahl%"=="32" goto 32GB
if "%wahl%"=="64" goto 64GB
goto Eula

:4GB
echo Bei 4GB Gesamtspeicher wird der Server leider kaum laufen.
pause
goto Eula

:8GB
echo Mit 8GB RAM wird es eng. 
echo Dein Server bleibt bei den standardmaessigen 4GB.
echo Hoeher solltest du bei 8GB Gesamtspeicher nicht gehen! 
pause
goto Eula

:16GB
echo 16GB RAM sind super für einen Minecraft-Server!
echo Ich optimiere die "start_server.bat" jetzt für dich.
echo java -Xmx8G -Xms4G -jar paper.jar nogui > "%name%\start_server.bat"
echo pause >> "%name%\start_server.bat"
echo.
echo Erledigt! Der Server-RAM wurde auf 8GB erhoeht.
pause
goto Eula

:32GB
echo Uh, 32GB RAM! Das sind ordentlich Ressourcen.
echo Wir geben dem Server 8GB RAM - das reicht locker für Freunde und Plugins!
echo Keine Sorge, ich schreibe die Start-Datei für dich um.
echo java -Xmx8G -Xms4G -jar paper.jar nogui > "%name%\start_server.bat"
echo pause >> "%name%\start_server.bat"
echo.
echo Fertig! Dein Server hat jetzt 8GB RAM zugewiesen bekommen.
pause
goto Eula

:64GB
echo Oha, 64GB? Komplett übertrieben! XD
echo Aber so viel braucht Minecraft gar nicht. 8GB bis 10GB sind das Maximum.
echo Ich stelle den Server auf stabile 8GB ein, das ist perfekt.
echo java -Xmx8G -Xms4G -jar paper.jar nogui > "%name%\start_server.bat"
echo pause >> "%name%\start_server.bat"
echo.
echo Alles klar! Dein Server ist jetzt auf 8GB RAM konfiguriert.
pause
goto Eula

:Eula
cls
echo === DER EULA-CHECK ===
echo Der Server wird beim ersten Mal stoppen. 
echo Suche die Datei "eula.txt" im Ordner.
echo Aendere "eula=false" zu "eula=true".
echo Danach den Server einfach nochmal starten.
echo.
echo HINWEIS: Portfreigabe (25565) im Router nicht vergessen, 
echo falls Freunde mitspielen sollen!
echo.
echo Viel Spass mit deinem Server!
pause
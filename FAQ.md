## ❓ Häufige Fragen (FAQ)
---

### Der Server startet nicht?
1. Guckt in der konsole nach was da steht, vielleicht hat der Server Ordner ein sonderzeichen. den einfach entfernen. 
2. Java-Version: Prüfe, ob du die richtige Java-Version installiert hast
- Für die neuesten Minecraft-Versionen brauchst du Java 21.
- Du kannst es kostenlos bei [Adoptium (Temurin)](https://adoptium.net/de) laden.
- Wähle dort das "JDK" für dein Betriebssystem (meistens Windows x64).

### Wie komme ich auf den Server?
1. Starte deinen Minecraft-Client (egal ob Standard-Launcher, LabyMod, CurseForge etc.).
2. Gehe auf Mehrspieler -> Server hinzufügen.
3. Gib als Adresse `localhost` ein. Danach kannst du dem Server beitreten.

### Wie können Freunde dem Server beitreten?
Dafür musst du den Port freigeben. Wichtige Warnung: Gib deine IP-Adresse nur Leuten, denen du vertraust, da man sonst theoretisch "geddost" werden kann.

1. Firewall: Du musst in der Windows-Firewall eine neue eingehende Regel erstellen. Gib dort den Port 25565 für TCP und UDP frei.
2. Router-Freigabe: Du musst den Port auch in deinem Router weiterleiten:
- Gib die IP deines Routers im Browser ein und logge dich ein (die Zugangsdaten stehen oft auf der Unterseite des Routers).
- Suche nach Einstellungen wie Portfreigabe, Port Forwarding oder Internet-Freigaben.
- Erstelle eine Regel, bei der sowohl der externe als auch der interne Port auf 25565 stehen.
- Wähle als Protokoll TCP/UDP aus (manche Router brauchen für beides eine eigene Regel).
- Gehe dann im Browser auf [whatismyipaddress.com](https://whatismyipaddress.com/de/meine-ip) Die dort angezeigte IPv4 ist deine öffentliche IP.

Diese öffentliche IP kannst du jetzt deinen Freunden geben, damit sie auf deinen Server joinen können!
Damit bist du startklar für dein Projekt! Viel Erfolg beim Server-Hosten.

---

Noch Fragen? Dann eröffne gerne ein **Issue**!

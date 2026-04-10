using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Minecraft_server_helfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // 1. Name aus der TextBox holen
                string serverName = textBox1.Text;

                // Falls das Feld leer ist, geben wir eine Warnung aus
                if (string.IsNullOrWhiteSpace(serverName))
                {
                    MessageBox.Show("Bitte gib einen Namen für deinen Server ein!");
                    return;
                }

                // 2. Pfad auf dem Desktop festlegen
                string pfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), serverName);

                // 3. Ordner erstellen
                if (!Directory.Exists(pfad))
                {
                    Directory.CreateDirectory(pfad);
                }

                // 4. Die eula.txt automatisch erstellen (Spart dem User Schritt 4!)
                File.WriteAllText(Path.Combine(pfad, "eula.txt"), "eula=true");

                // 5. Die start.bat mit 8GB RAM erstellen
                string batchInhalt = $"@echo off\ntitle {serverName}\njava -Xms8G -Xmx8G -jar paper.jar nogui\npause";
                File.WriteAllText(Path.Combine(pfad, "start.bat"), batchInhalt);

                // 6. Die Download-Seite für die paper.jar öffnen
                // (Später können wir das durch einen automatischen Download ersetzen!)
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://papermc.io/downloads/paper",
                    UseShellExecute = true
                });

                // 7. Erfolg melden
                MessageBox.Show("Erfolg! Der Server-Ordner wurde auf deinem Desktop vorbereitet.\n\n" +
                                "Nächste Schritte:\n" +
                                "1. Lade die Server-Datei von der Webseite herunter.\n" +
                                "2. Verschiebe sie in den neuen Ordner.\n" +
                                "3. Benenne die Datei exakt in 'paper.jar' um.\n\n" +
                                "Danach kannst du die start.bat starten!",
                                "Server Vorbereitung",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da ist etwas schiefgelaufen: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/philipgamer/Minecraft-Server-helfer?tab=MIT-1-ov-file") { UseShellExecute = true });
        }
    }
}

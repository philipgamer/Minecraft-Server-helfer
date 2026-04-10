namespace Minecraft_server_helfer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 32);
            label1.TabIndex = 0;
            label1.Text = "Hey! ich bin dein Minecraft server helfer!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 65);
            label2.Name = "label2";
            label2.Size = new Size(426, 32);
            label2.TabIndex = 0;
            label2.Text = "Sag mir wie soll dein Server heißen?";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(31, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "Hier eingeben!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 164);
            label3.Name = "label3";
            label3.Size = new Size(430, 64);
            label3.TabIndex = 0;
            label3.Text = "Der Minecraft server wird \r\nstandardmäßig mit 8GB ram erstellt.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(31, 228);
            label4.Name = "label4";
            label4.Size = new Size(495, 96);
            label4.TabIndex = 0;
            label4.Text = "willst du das ändern. musst du die \r\n\"start.bat.\" bearbeiten. und den wert\r\nbei -Xmx8G ändern auf deine wunschwert";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(31, 375);
            label5.Name = "label5";
            label5.Size = new Size(475, 64);
            label5.TabIndex = 0;
            label5.Text = "Klick jetzt einfach auf \"Server erstellen\" \r\ndu musst nichts mehr machen! ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(165, 453);
            button1.Name = "button1";
            button1.Size = new Size(193, 41);
            button1.TabIndex = 2;
            button1.Text = "Server erstellen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(0, 623);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 3;
            label6.Text = "© 2026 PhilipGamer";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(565, 644);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Minecraft Server Helfer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
    }
}
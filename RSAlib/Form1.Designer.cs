namespace RSAlib
{
    partial class RSA
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            this.label1 = new System.Windows.Forms.Label();
            this.Cifra = new System.Windows.Forms.Button();
            this.radioButton512 = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton2048 = new System.Windows.Forms.RadioButton();
            this.radioButton4096 = new System.Windows.Forms.RadioButton();
            this.iniziale = new System.Windows.Forms.TextBox();
            this.cifrata = new System.Windows.Forms.TextBox();
            this.decifrata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textpub = new System.Windows.Forms.TextBox();
            this.textpriv = new System.Windows.Forms.TextBox();
            this.Decifra = new System.Windows.Forms.Button();
            this.cifdec = new System.Windows.Forms.Button();
            this.Genera = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaFinestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaConNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.informazioniSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.visualizzaGuidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiave:";
            // 
            // Cifra
            // 
            this.Cifra.BackColor = System.Drawing.Color.Transparent;
            this.Cifra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cifra.FlatAppearance.BorderSize = 0;
            this.Cifra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cifra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cifra.Location = new System.Drawing.Point(53, 317);
            this.Cifra.Name = "Cifra";
            this.Cifra.Size = new System.Drawing.Size(195, 50);
            this.Cifra.TabIndex = 2;
            this.Cifra.Text = "Cifra";
            this.Cifra.UseVisualStyleBackColor = false;
            this.Cifra.Click += new System.EventHandler(this.Cifra_Click);
            // 
            // radioButton512
            // 
            this.radioButton512.AutoSize = true;
            this.radioButton512.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton512.Location = new System.Drawing.Point(165, 58);
            this.radioButton512.Name = "radioButton512";
            this.radioButton512.Size = new System.Drawing.Size(83, 27);
            this.radioButton512.TabIndex = 4;
            this.radioButton512.Text = "512 bit";
            this.radioButton512.UseVisualStyleBackColor = true;
            this.radioButton512.CheckedChanged += new System.EventHandler(this.radioButton512_CheckedChanged);
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1024.Location = new System.Drawing.Point(274, 58);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(92, 27);
            this.radioButton1024.TabIndex = 5;
            this.radioButton1024.Text = "1024 bit";
            this.radioButton1024.UseVisualStyleBackColor = true;
            this.radioButton1024.CheckedChanged += new System.EventHandler(this.radioButton1024_CheckedChanged);
            // 
            // radioButton2048
            // 
            this.radioButton2048.AutoSize = true;
            this.radioButton2048.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2048.Location = new System.Drawing.Point(383, 58);
            this.radioButton2048.Name = "radioButton2048";
            this.radioButton2048.Size = new System.Drawing.Size(92, 27);
            this.radioButton2048.TabIndex = 6;
            this.radioButton2048.Text = "2048 bit";
            this.radioButton2048.UseVisualStyleBackColor = true;
            this.radioButton2048.CheckedChanged += new System.EventHandler(this.radioButton2048_CheckedChanged);
            // 
            // radioButton4096
            // 
            this.radioButton4096.AutoSize = true;
            this.radioButton4096.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4096.Location = new System.Drawing.Point(492, 58);
            this.radioButton4096.Name = "radioButton4096";
            this.radioButton4096.Size = new System.Drawing.Size(92, 27);
            this.radioButton4096.TabIndex = 7;
            this.radioButton4096.Text = "4096 bit";
            this.radioButton4096.UseVisualStyleBackColor = true;
            this.radioButton4096.CheckedChanged += new System.EventHandler(this.radioButton4096_CheckedChanged);
            // 
            // iniziale
            // 
            this.iniziale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniziale.Location = new System.Drawing.Point(244, 416);
            this.iniziale.Name = "iniziale";
            this.iniziale.Size = new System.Drawing.Size(578, 27);
            this.iniziale.TabIndex = 8;
            // 
            // cifrata
            // 
            this.cifrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cifrata.Location = new System.Drawing.Point(244, 483);
            this.cifrata.Name = "cifrata";
            this.cifrata.Size = new System.Drawing.Size(578, 27);
            this.cifrata.TabIndex = 9;
            // 
            // decifrata
            // 
            this.decifrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decifrata.Location = new System.Drawing.Point(244, 550);
            this.decifrata.Name = "decifrata";
            this.decifrata.Size = new System.Drawing.Size(578, 27);
            this.decifrata.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stringa iniziale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stringa cifrata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stringa decifrata:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chiave pubblica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chiave privata:";
            // 
            // textpub
            // 
            this.textpub.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpub.Location = new System.Drawing.Point(244, 128);
            this.textpub.Name = "textpub";
            this.textpub.Size = new System.Drawing.Size(340, 30);
            this.textpub.TabIndex = 16;
            // 
            // textpriv
            // 
            this.textpriv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpriv.Location = new System.Drawing.Point(244, 174);
            this.textpriv.Name = "textpriv";
            this.textpriv.Size = new System.Drawing.Size(340, 30);
            this.textpriv.TabIndex = 17;
            // 
            // Decifra
            // 
            this.Decifra.BackColor = System.Drawing.Color.Transparent;
            this.Decifra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decifra.FlatAppearance.BorderSize = 0;
            this.Decifra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Decifra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decifra.Location = new System.Drawing.Point(254, 317);
            this.Decifra.Name = "Decifra";
            this.Decifra.Size = new System.Drawing.Size(194, 50);
            this.Decifra.TabIndex = 18;
            this.Decifra.Text = "Decifra";
            this.Decifra.UseVisualStyleBackColor = false;
            this.Decifra.Click += new System.EventHandler(this.Decifra_Click);
            // 
            // cifdec
            // 
            this.cifdec.BackColor = System.Drawing.Color.Transparent;
            this.cifdec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cifdec.FlatAppearance.BorderSize = 0;
            this.cifdec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cifdec.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cifdec.Location = new System.Drawing.Point(454, 317);
            this.cifdec.Name = "cifdec";
            this.cifdec.Size = new System.Drawing.Size(195, 50);
            this.cifdec.TabIndex = 19;
            this.cifdec.Text = "Cifra e Decifra";
            this.cifdec.UseVisualStyleBackColor = false;
            this.cifdec.Click += new System.EventHandler(this.cifdec_Click);
            // 
            // Genera
            // 
            this.Genera.BackColor = System.Drawing.Color.Transparent;
            this.Genera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Genera.FlatAppearance.BorderSize = 0;
            this.Genera.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Genera.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genera.Location = new System.Drawing.Point(622, 126);
            this.Genera.Name = "Genera";
            this.Genera.Size = new System.Drawing.Size(277, 78);
            this.Genera.TabIndex = 20;
            this.Genera.Text = "Genera chiavi casuali";
            this.Genera.UseVisualStyleBackColor = false;
            this.Genera.Click += new System.EventHandler(this.Genera_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1030, 27);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.nuovaFinestraToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.salvaConNomeToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 24);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.nuovoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.nuovoToolStripMenuItem.Text = "Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // nuovaFinestraToolStripMenuItem
            // 
            this.nuovaFinestraToolStripMenuItem.Name = "nuovaFinestraToolStripMenuItem";
            this.nuovaFinestraToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+MAIUSC+N";
            this.nuovaFinestraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.nuovaFinestraToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.nuovaFinestraToolStripMenuItem.Text = "Nuova finestra";
            this.nuovaFinestraToolStripMenuItem.Click += new System.EventHandler(this.nuovaFinestraToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.apriToolStripMenuItem.Text = "Apri";
            this.apriToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.salvaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // salvaConNomeToolStripMenuItem
            // 
            this.salvaConNomeToolStripMenuItem.Name = "salvaConNomeToolStripMenuItem";
            this.salvaConNomeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+MAIUSC+N";
            this.salvaConNomeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvaConNomeToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.salvaConNomeToolStripMenuItem.Text = "Salva con nome";
            this.salvaConNomeToolStripMenuItem.Click += new System.EventHandler(this.salvaConNomeToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaGuidaToolStripMenuItem,
            this.informazioniSuToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(20, 24);
            this.toolStripDropDownButton2.Text = "?";
            // 
            // informazioniSuToolStripMenuItem
            // 
            this.informazioniSuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.informazioniSuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.informazioniSuToolStripMenuItem.Name = "informazioniSuToolStripMenuItem";
            this.informazioniSuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.informazioniSuToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.informazioniSuToolStripMenuItem.Text = "Informazioni su Calcolo RSA";
            this.informazioniSuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informazioniSuToolStripMenuItem.Click += new System.EventHandler(this.informazioniSuToolStripMenuItem_Click);
            // 
            // visualizzaGuidaToolStripMenuItem
            // 
            this.visualizzaGuidaToolStripMenuItem.Name = "visualizzaGuidaToolStripMenuItem";
            this.visualizzaGuidaToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.visualizzaGuidaToolStripMenuItem.Text = "Visualizza Guida";
            this.visualizzaGuidaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaGuidaToolStripMenuItem_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1030, 647);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Genera);
            this.Controls.Add(this.cifdec);
            this.Controls.Add(this.Decifra);
            this.Controls.Add(this.textpriv);
            this.Controls.Add(this.textpub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decifrata);
            this.Controls.Add(this.cifrata);
            this.Controls.Add(this.iniziale);
            this.Controls.Add(this.radioButton4096);
            this.Controls.Add(this.radioButton2048);
            this.Controls.Add(this.radioButton1024);
            this.Controls.Add(this.radioButton512);
            this.Controls.Add(this.Cifra);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSA";
            this.Text = "Calcolo RSA";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cifra;
        private System.Windows.Forms.RadioButton radioButton512;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton2048;
        private System.Windows.Forms.RadioButton radioButton4096;
        private System.Windows.Forms.TextBox iniziale;
        private System.Windows.Forms.TextBox cifrata;
        private System.Windows.Forms.TextBox decifrata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textpub;
        private System.Windows.Forms.TextBox textpriv;
        private System.Windows.Forms.Button Decifra;
        private System.Windows.Forms.Button cifdec;
        private System.Windows.Forms.Button Genera;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaConNomeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaFinestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem visualizzaGuidaToolStripMenuItem;
    }
}


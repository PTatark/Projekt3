namespace Projekt3
{
    partial class PrezentacjaLosowaZeSlajderem
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
            this.components = new System.ComponentModel.Container();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.chbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrzesun = new System.Windows.Forms.Button();
            this.btnAtrybutyGeo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnWlaczenieSlajdera = new System.Windows.Forms.Button();
            this.btnWylaczenieSlajdera = new System.Windows.Forms.Button();
            this.gbTrybPokazu = new System.Windows.Forms.GroupBox();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndexTFG = new System.Windows.Forms.TextBox();
            this.gbOpcjeManual = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbTrybPokazu.SuspendLayout();
            this.gbOpcjeManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPowrot
            // 
            this.btnPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrot.Location = new System.Drawing.Point(1006, 12);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(240, 82);
            this.btnPowrot.TabIndex = 0;
            this.btnPowrot.Text = "Powrót do głównego formularza";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(223, 59);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(747, 481);
            this.pbRysownica.TabIndex = 1;
            this.pbRysownica.TabStop = false;
            // 
            // chbFiguryGeometryczne
            // 
            this.chbFiguryGeometryczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbFiguryGeometryczne.FormattingEnabled = true;
            this.chbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Koło",
            "Prostokąt",
            "Kwadrat"});
            this.chbFiguryGeometryczne.Location = new System.Drawing.Point(1006, 122);
            this.chbFiguryGeometryczne.Name = "chbFiguryGeometryczne";
            this.chbFiguryGeometryczne.Size = new System.Drawing.Size(240, 403);
            this.chbFiguryGeometryczne.TabIndex = 2;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblN.Location = new System.Drawing.Point(12, 12);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(247, 20);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "Podaj liczbę figur geometrycznych";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtN.Location = new System.Drawing.Point(38, 41);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(133, 26);
            this.txtN.TabIndex = 4;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(26, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 71);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Wykreśl figury";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPrzesun
            // 
            this.btnPrzesun.Enabled = false;
            this.btnPrzesun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesun.Location = new System.Drawing.Point(26, 150);
            this.btnPrzesun.Name = "btnPrzesun";
            this.btnPrzesun.Size = new System.Drawing.Size(154, 72);
            this.btnPrzesun.TabIndex = 6;
            this.btnPrzesun.Text = "Nowa lokalizacja\r\n(przesunięcie)";
            this.btnPrzesun.UseVisualStyleBackColor = true;
            this.btnPrzesun.Click += new System.EventHandler(this.btnPrzesun_Click);
            // 
            // btnAtrybutyGeo
            // 
            this.btnAtrybutyGeo.Enabled = false;
            this.btnAtrybutyGeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAtrybutyGeo.Location = new System.Drawing.Point(26, 228);
            this.btnAtrybutyGeo.Name = "btnAtrybutyGeo";
            this.btnAtrybutyGeo.Size = new System.Drawing.Size(154, 79);
            this.btnAtrybutyGeo.TabIndex = 7;
            this.btnAtrybutyGeo.Text = "Wylosowanie nowej lokalizacji i atrybutów";
            this.btnAtrybutyGeo.UseVisualStyleBackColor = true;
            this.btnAtrybutyGeo.Click += new System.EventHandler(this.btnAtrybutyGeo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "0";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnWlaczenieSlajdera
            // 
            this.btnWlaczenieSlajdera.Enabled = false;
            this.btnWlaczenieSlajdera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczenieSlajdera.Location = new System.Drawing.Point(26, 313);
            this.btnWlaczenieSlajdera.Name = "btnWlaczenieSlajdera";
            this.btnWlaczenieSlajdera.Size = new System.Drawing.Size(154, 73);
            this.btnWlaczenieSlajdera.TabIndex = 8;
            this.btnWlaczenieSlajdera.Text = "Włączenie slajdera";
            this.btnWlaczenieSlajdera.UseVisualStyleBackColor = true;
            this.btnWlaczenieSlajdera.Click += new System.EventHandler(this.btnWlaczenieSlajdera_Click);
            // 
            // btnWylaczenieSlajdera
            // 
            this.btnWylaczenieSlajdera.Enabled = false;
            this.btnWylaczenieSlajdera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczenieSlajdera.Location = new System.Drawing.Point(26, 392);
            this.btnWylaczenieSlajdera.Name = "btnWylaczenieSlajdera";
            this.btnWylaczenieSlajdera.Size = new System.Drawing.Size(154, 70);
            this.btnWylaczenieSlajdera.TabIndex = 9;
            this.btnWylaczenieSlajdera.Text = "Wyłączenie slajdera";
            this.btnWylaczenieSlajdera.UseVisualStyleBackColor = true;
            this.btnWylaczenieSlajdera.Click += new System.EventHandler(this.btnWylaczenieSlajdera_Click);
            // 
            // gbTrybPokazu
            // 
            this.gbTrybPokazu.Controls.Add(this.rdbManualny);
            this.gbTrybPokazu.Controls.Add(this.rdbAutomatyczny);
            this.gbTrybPokazu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTrybPokazu.Location = new System.Drawing.Point(223, 595);
            this.gbTrybPokazu.Name = "gbTrybPokazu";
            this.gbTrybPokazu.Size = new System.Drawing.Size(268, 84);
            this.gbTrybPokazu.TabIndex = 10;
            this.gbTrybPokazu.TabStop = false;
            this.gbTrybPokazu.Text = "Tryb pokazu figur geometrycznych";
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Location = new System.Drawing.Point(7, 49);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(229, 20);
            this.rdbManualny.TabIndex = 1;
            this.rdbManualny.TabStop = true;
            this.rdbManualny.Text = "Manualny (sterowany przyciskami)";
            this.rdbManualny.UseVisualStyleBackColor = true;
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Checked = true;
            this.rdbAutomatyczny.Location = new System.Drawing.Point(7, 22);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(236, 20);
            this.rdbAutomatyczny.TabIndex = 0;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "Automatyczny (sterowany zegarem)";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(153, 73);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(108, 42);
            this.btnNastepna.TabIndex = 11;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(39, 74);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(108, 42);
            this.btnPoprzednia.TabIndex = 12;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Index figury w tablicy TFG";
            // 
            // txtIndexTFG
            // 
            this.txtIndexTFG.Enabled = false;
            this.txtIndexTFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIndexTFG.Location = new System.Drawing.Point(99, 45);
            this.txtIndexTFG.Name = "txtIndexTFG";
            this.txtIndexTFG.Size = new System.Drawing.Size(100, 22);
            this.txtIndexTFG.TabIndex = 14;
            this.txtIndexTFG.Text = "0";
            this.txtIndexTFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndexTFG.TextChanged += new System.EventHandler(this.txtIndexTFG_TextChanged);
            // 
            // gbOpcjeManual
            // 
            this.gbOpcjeManual.Controls.Add(this.label1);
            this.gbOpcjeManual.Controls.Add(this.txtIndexTFG);
            this.gbOpcjeManual.Controls.Add(this.btnNastepna);
            this.gbOpcjeManual.Controls.Add(this.btnPoprzednia);
            this.gbOpcjeManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOpcjeManual.Location = new System.Drawing.Point(576, 560);
            this.gbOpcjeManual.Name = "gbOpcjeManual";
            this.gbOpcjeManual.Size = new System.Drawing.Size(285, 135);
            this.gbOpcjeManual.TabIndex = 15;
            this.gbOpcjeManual.TabStop = false;
            this.gbOpcjeManual.Text = "Opcje manualnego slajdera";
            // 
            // PrezentacjaLosowaZeSlajderem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 715);
            this.Controls.Add(this.gbOpcjeManual);
            this.Controls.Add(this.gbTrybPokazu);
            this.Controls.Add(this.btnWylaczenieSlajdera);
            this.Controls.Add(this.btnWlaczenieSlajdera);
            this.Controls.Add(this.btnAtrybutyGeo);
            this.Controls.Add(this.btnPrzesun);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.chbFiguryGeometryczne);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnPowrot);
            this.Name = "PrezentacjaLosowaZeSlajderem";
            this.Text = "PrezentacjaLosowaZeSlajderem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrezentacjaLosowaZeSlajderem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrezentacjaLosowaZeSlajderem_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbTrybPokazu.ResumeLayout(false);
            this.gbTrybPokazu.PerformLayout();
            this.gbOpcjeManual.ResumeLayout(false);
            this.gbOpcjeManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.CheckedListBox chbFiguryGeometryczne;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPrzesun;
        private System.Windows.Forms.Button btnAtrybutyGeo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtIndexTFG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.GroupBox gbTrybPokazu;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.Button btnWylaczenieSlajdera;
        private System.Windows.Forms.Button btnWlaczenieSlajdera;
        private System.Windows.Forms.GroupBox gbOpcjeManual;
    }
}
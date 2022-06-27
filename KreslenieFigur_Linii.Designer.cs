namespace Projekt3
{
    partial class KreslenieFigur_Linii
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
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.gbFigury_Linie = new System.Windows.Forms.GroupBox();
            this.rdbDrawPie = new System.Windows.Forms.RadioButton();
            this.rdbForemny = new System.Windows.Forms.RadioButton();
            this.rdbKwadrat = new System.Windows.Forms.RadioButton();
            this.rdbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.rdbLiniaKreslonaMysza = new System.Windows.Forms.RadioButton();
            this.rdbProstokat = new System.Windows.Forms.RadioButton();
            this.rdbKolo = new System.Windows.Forms.RadioButton();
            this.rdbOkrag = new System.Windows.Forms.RadioButton();
            this.rdbElipsa = new System.Windows.Forms.RadioButton();
            this.rdbLinia = new System.Windows.Forms.RadioButton();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.btnWlaczenieSlajdera = new System.Windows.Forms.Button();
            this.btnWylaczenieSlajdera = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnZapisBitmapa = new System.Windows.Forms.Button();
            this.btnWczytanieBitmapa = new System.Windows.Forms.Button();
            this.gbAtrybutyGraficzne = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.trbSuwakGrubosci = new System.Windows.Forms.TrackBar();
            this.txtKolorWypelnienia = new System.Windows.Forms.TextBox();
            this.txtKolorLinii = new System.Windows.Forms.TextBox();
            this.btnKolorWypelnienia = new System.Windows.Forms.Button();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.gbTrybPokazu = new System.Windows.Forms.GroupBox();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnPrzesun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCofnij = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbOpcjeManual = new System.Windows.Forms.GroupBox();
            this.gbOpcjefigur = new System.Windows.Forms.GroupBox();
            this.gbInneOpcje = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gbFigury_Linie.SuspendLayout();
            this.gbAtrybutyGraficzne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSuwakGrubosci)).BeginInit();
            this.gbTrybPokazu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbOpcjeManual.SuspendLayout();
            this.gbOpcjefigur.SuspendLayout();
            this.gbInneOpcje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(43, 71);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(876, 438);
            this.pbRysownica.TabIndex = 0;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // gbFigury_Linie
            // 
            this.gbFigury_Linie.Controls.Add(this.rdbDrawPie);
            this.gbFigury_Linie.Controls.Add(this.rdbForemny);
            this.gbFigury_Linie.Controls.Add(this.rdbKwadrat);
            this.gbFigury_Linie.Controls.Add(this.rdbKrzywaBeziera);
            this.gbFigury_Linie.Controls.Add(this.rdbLiniaKreslonaMysza);
            this.gbFigury_Linie.Controls.Add(this.rdbProstokat);
            this.gbFigury_Linie.Controls.Add(this.rdbKolo);
            this.gbFigury_Linie.Controls.Add(this.rdbOkrag);
            this.gbFigury_Linie.Controls.Add(this.rdbElipsa);
            this.gbFigury_Linie.Controls.Add(this.rdbLinia);
            this.gbFigury_Linie.Controls.Add(this.rdbPunkt);
            this.gbFigury_Linie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbFigury_Linie.Location = new System.Drawing.Point(950, 41);
            this.gbFigury_Linie.Name = "gbFigury_Linie";
            this.gbFigury_Linie.Size = new System.Drawing.Size(286, 305);
            this.gbFigury_Linie.TabIndex = 1;
            this.gbFigury_Linie.TabStop = false;
            this.gbFigury_Linie.Text = "Wybierz figurę lub linię";
            // 
            // rdbDrawPie
            // 
            this.rdbDrawPie.AutoSize = true;
            this.rdbDrawPie.Location = new System.Drawing.Point(126, 120);
            this.rdbDrawPie.Name = "rdbDrawPie";
            this.rdbDrawPie.Size = new System.Drawing.Size(76, 20);
            this.rdbDrawPie.TabIndex = 10;
            this.rdbDrawPie.TabStop = true;
            this.rdbDrawPie.Text = "DrawPie";
            this.rdbDrawPie.UseVisualStyleBackColor = true;
            // 
            // rdbForemny
            // 
            this.rdbForemny.AutoSize = true;
            this.rdbForemny.Location = new System.Drawing.Point(126, 94);
            this.rdbForemny.Name = "rdbForemny";
            this.rdbForemny.Size = new System.Drawing.Size(134, 20);
            this.rdbForemny.TabIndex = 9;
            this.rdbForemny.TabStop = true;
            this.rdbForemny.Text = "Wielokąt Foremny";
            this.rdbForemny.UseVisualStyleBackColor = true;
            // 
            // rdbKwadrat
            // 
            this.rdbKwadrat.AutoSize = true;
            this.rdbKwadrat.Location = new System.Drawing.Point(6, 94);
            this.rdbKwadrat.Name = "rdbKwadrat";
            this.rdbKwadrat.Size = new System.Drawing.Size(73, 20);
            this.rdbKwadrat.TabIndex = 8;
            this.rdbKwadrat.TabStop = true;
            this.rdbKwadrat.Text = "Kwadrat";
            this.rdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rdbKrzywaBeziera
            // 
            this.rdbKrzywaBeziera.AutoSize = true;
            this.rdbKrzywaBeziera.Location = new System.Drawing.Point(6, 120);
            this.rdbKrzywaBeziera.Name = "rdbKrzywaBeziera";
            this.rdbKrzywaBeziera.Size = new System.Drawing.Size(116, 20);
            this.rdbKrzywaBeziera.TabIndex = 7;
            this.rdbKrzywaBeziera.TabStop = true;
            this.rdbKrzywaBeziera.Text = "Krzywa Beziera";
            this.rdbKrzywaBeziera.UseVisualStyleBackColor = true;
            this.rdbKrzywaBeziera.CheckedChanged += new System.EventHandler(this.rdbKrzywaBeziera_CheckedChanged);
            // 
            // rdbLiniaKreslonaMysza
            // 
            this.rdbLiniaKreslonaMysza.AutoSize = true;
            this.rdbLiniaKreslonaMysza.Location = new System.Drawing.Point(6, 146);
            this.rdbLiniaKreslonaMysza.Name = "rdbLiniaKreslonaMysza";
            this.rdbLiniaKreslonaMysza.Size = new System.Drawing.Size(150, 20);
            this.rdbLiniaKreslonaMysza.TabIndex = 6;
            this.rdbLiniaKreslonaMysza.TabStop = true;
            this.rdbLiniaKreslonaMysza.Text = "Linia kreślona myszą";
            this.rdbLiniaKreslonaMysza.UseVisualStyleBackColor = true;
            // 
            // rdbProstokat
            // 
            this.rdbProstokat.AutoSize = true;
            this.rdbProstokat.Location = new System.Drawing.Point(126, 68);
            this.rdbProstokat.Name = "rdbProstokat";
            this.rdbProstokat.Size = new System.Drawing.Size(82, 20);
            this.rdbProstokat.TabIndex = 5;
            this.rdbProstokat.TabStop = true;
            this.rdbProstokat.Text = "Prostokąt";
            this.rdbProstokat.UseVisualStyleBackColor = true;
            // 
            // rdbKolo
            // 
            this.rdbKolo.AutoSize = true;
            this.rdbKolo.Location = new System.Drawing.Point(6, 68);
            this.rdbKolo.Name = "rdbKolo";
            this.rdbKolo.Size = new System.Drawing.Size(55, 20);
            this.rdbKolo.TabIndex = 4;
            this.rdbKolo.TabStop = true;
            this.rdbKolo.Text = "Koło";
            this.rdbKolo.UseVisualStyleBackColor = true;
            // 
            // rdbOkrag
            // 
            this.rdbOkrag.AutoSize = true;
            this.rdbOkrag.Location = new System.Drawing.Point(126, 44);
            this.rdbOkrag.Name = "rdbOkrag";
            this.rdbOkrag.Size = new System.Drawing.Size(62, 20);
            this.rdbOkrag.TabIndex = 3;
            this.rdbOkrag.TabStop = true;
            this.rdbOkrag.Text = "Okrąg";
            this.rdbOkrag.UseVisualStyleBackColor = true;
            // 
            // rdbElipsa
            // 
            this.rdbElipsa.AutoSize = true;
            this.rdbElipsa.Location = new System.Drawing.Point(6, 44);
            this.rdbElipsa.Name = "rdbElipsa";
            this.rdbElipsa.Size = new System.Drawing.Size(63, 20);
            this.rdbElipsa.TabIndex = 2;
            this.rdbElipsa.TabStop = true;
            this.rdbElipsa.Text = "Elipsa";
            this.rdbElipsa.UseVisualStyleBackColor = true;
            // 
            // rdbLinia
            // 
            this.rdbLinia.AutoSize = true;
            this.rdbLinia.Location = new System.Drawing.Point(126, 20);
            this.rdbLinia.Name = "rdbLinia";
            this.rdbLinia.Size = new System.Drawing.Size(95, 20);
            this.rdbLinia.TabIndex = 1;
            this.rdbLinia.TabStop = true;
            this.rdbLinia.Text = "Linia Prosta";
            this.rdbLinia.UseVisualStyleBackColor = true;
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Location = new System.Drawing.Point(6, 20);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(58, 20);
            this.rdbPunkt.TabIndex = 0;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(257, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Współrzędne (x, y) położenia myszy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(89, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numer figury (index)";
            // 
            // btnPowrot
            // 
            this.btnPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrot.Location = new System.Drawing.Point(51, 33);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(190, 65);
            this.btnPowrot.TabIndex = 6;
            this.btnPowrot.Text = "Powrót do głównego formularza";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // btnWlaczenieSlajdera
            // 
            this.btnWlaczenieSlajdera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczenieSlajdera.Location = new System.Drawing.Point(15, 34);
            this.btnWlaczenieSlajdera.Name = "btnWlaczenieSlajdera";
            this.btnWlaczenieSlajdera.Size = new System.Drawing.Size(135, 66);
            this.btnWlaczenieSlajdera.TabIndex = 9;
            this.btnWlaczenieSlajdera.Text = "Włącz slajder";
            this.btnWlaczenieSlajdera.UseVisualStyleBackColor = true;
            this.btnWlaczenieSlajdera.Click += new System.EventHandler(this.btnWlaczenieSlajdera_Click);
            // 
            // btnWylaczenieSlajdera
            // 
            this.btnWylaczenieSlajdera.Enabled = false;
            this.btnWylaczenieSlajdera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczenieSlajdera.Location = new System.Drawing.Point(156, 34);
            this.btnWylaczenieSlajdera.Name = "btnWylaczenieSlajdera";
            this.btnWylaczenieSlajdera.Size = new System.Drawing.Size(135, 66);
            this.btnWylaczenieSlajdera.TabIndex = 10;
            this.btnWylaczenieSlajdera.Text = "Wyłącz slajder";
            this.btnWylaczenieSlajdera.UseVisualStyleBackColor = true;
            this.btnWylaczenieSlajdera.Click += new System.EventHandler(this.btnWylaczenieSlajdera_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(14, 80);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(135, 66);
            this.btnPoprzednia.TabIndex = 11;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // btnNastepna
            // 
            this.btnNastepna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(155, 80);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(135, 66);
            this.btnNastepna.TabIndex = 12;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnZapisBitmapa
            // 
            this.btnZapisBitmapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisBitmapa.Location = new System.Drawing.Point(6, 104);
            this.btnZapisBitmapa.Name = "btnZapisBitmapa";
            this.btnZapisBitmapa.Size = new System.Drawing.Size(143, 57);
            this.btnZapisBitmapa.TabIndex = 13;
            this.btnZapisBitmapa.Text = "Zapisz bitmape w pliku";
            this.btnZapisBitmapa.UseVisualStyleBackColor = true;
            this.btnZapisBitmapa.Click += new System.EventHandler(this.btnZapisBitmapa_Click);
            // 
            // btnWczytanieBitmapa
            // 
            this.btnWczytanieBitmapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWczytanieBitmapa.Location = new System.Drawing.Point(158, 104);
            this.btnWczytanieBitmapa.Name = "btnWczytanieBitmapa";
            this.btnWczytanieBitmapa.Size = new System.Drawing.Size(134, 57);
            this.btnWczytanieBitmapa.TabIndex = 14;
            this.btnWczytanieBitmapa.Text = "Wczytaj bitmape z pliku";
            this.btnWczytanieBitmapa.UseVisualStyleBackColor = true;
            this.btnWczytanieBitmapa.Click += new System.EventHandler(this.btnWczytanieBitmapa_Click);
            // 
            // gbAtrybutyGraficzne
            // 
            this.gbAtrybutyGraficzne.Controls.Add(this.label3);
            this.gbAtrybutyGraficzne.Controls.Add(this.cmbStylLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.trbSuwakGrubosci);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorWypelnienia);
            this.gbAtrybutyGraficzne.Controls.Add(this.txtKolorLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorWypelnienia);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorLinii);
            this.gbAtrybutyGraficzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAtrybutyGraficzne.Location = new System.Drawing.Point(950, 352);
            this.gbAtrybutyGraficzne.Name = "gbAtrybutyGraficzne";
            this.gbAtrybutyGraficzne.Size = new System.Drawing.Size(286, 176);
            this.gbAtrybutyGraficzne.TabIndex = 15;
            this.gbAtrybutyGraficzne.TabStop = false;
            this.gbAtrybutyGraficzne.Text = "Atrybuty graficzne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ustaw grubość linii";
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Ciągła (Solid)",
            "Kreskowa (Dash)",
            "KreskowoKropkowa (DashDot)",
            "KreskowoKropkowaKropkowa (DashDotDot)",
            "Kropkowa (Dot)"});
            this.cmbStylLinii.Location = new System.Drawing.Point(144, 39);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(121, 24);
            this.cmbStylLinii.TabIndex = 22;
            this.cmbStylLinii.Text = "Wybierz styl linii";
            // 
            // trbSuwakGrubosci
            // 
            this.trbSuwakGrubosci.Location = new System.Drawing.Point(133, 104);
            this.trbSuwakGrubosci.Name = "trbSuwakGrubosci";
            this.trbSuwakGrubosci.Size = new System.Drawing.Size(147, 45);
            this.trbSuwakGrubosci.TabIndex = 4;
            this.trbSuwakGrubosci.Value = 2;
            // 
            // txtKolorWypelnienia
            // 
            this.txtKolorWypelnienia.BackColor = System.Drawing.Color.Lime;
            this.txtKolorWypelnienia.Location = new System.Drawing.Point(16, 139);
            this.txtKolorWypelnienia.Name = "txtKolorWypelnienia";
            this.txtKolorWypelnienia.ReadOnly = true;
            this.txtKolorWypelnienia.Size = new System.Drawing.Size(100, 22);
            this.txtKolorWypelnienia.TabIndex = 3;
            // 
            // txtKolorLinii
            // 
            this.txtKolorLinii.BackColor = System.Drawing.Color.Blue;
            this.txtKolorLinii.Location = new System.Drawing.Point(16, 50);
            this.txtKolorLinii.Name = "txtKolorLinii";
            this.txtKolorLinii.ReadOnly = true;
            this.txtKolorLinii.Size = new System.Drawing.Size(100, 22);
            this.txtKolorLinii.TabIndex = 2;
            // 
            // btnKolorWypelnienia
            // 
            this.btnKolorWypelnienia.Location = new System.Drawing.Point(16, 87);
            this.btnKolorWypelnienia.Name = "btnKolorWypelnienia";
            this.btnKolorWypelnienia.Size = new System.Drawing.Size(100, 46);
            this.btnKolorWypelnienia.TabIndex = 1;
            this.btnKolorWypelnienia.Text = "Kolor wypełnienia";
            this.btnKolorWypelnienia.UseVisualStyleBackColor = true;
            this.btnKolorWypelnienia.Click += new System.EventHandler(this.btnKolorWypelnienia_Click);
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.Location = new System.Drawing.Point(16, 21);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(100, 23);
            this.btnKolorLinii.TabIndex = 0;
            this.btnKolorLinii.Text = "Kolor linii";
            this.btnKolorLinii.UseVisualStyleBackColor = true;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // gbTrybPokazu
            // 
            this.gbTrybPokazu.Controls.Add(this.rdbManualny);
            this.gbTrybPokazu.Controls.Add(this.rdbAutomatyczny);
            this.gbTrybPokazu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTrybPokazu.Location = new System.Drawing.Point(43, 585);
            this.gbTrybPokazu.Name = "gbTrybPokazu";
            this.gbTrybPokazu.Size = new System.Drawing.Size(213, 96);
            this.gbTrybPokazu.TabIndex = 16;
            this.gbTrybPokazu.TabStop = false;
            this.gbTrybPokazu.Text = "Pokaz figur";
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Location = new System.Drawing.Point(121, 39);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(83, 20);
            this.rdbManualny.TabIndex = 1;
            this.rdbManualny.Text = "Manualny";
            this.rdbManualny.UseVisualStyleBackColor = true;
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Checked = true;
            this.rdbAutomatyczny.Location = new System.Drawing.Point(7, 39);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(108, 20);
            this.rdbAutomatyczny.TabIndex = 0;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "Automatyczny";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIndex.Location = new System.Drawing.Point(92, 52);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(119, 22);
            this.txtIndex.TabIndex = 17;
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(526, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(552, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(50, 20);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "Puste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(609, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Y";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(635, 27);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(50, 20);
            this.lblY.TabIndex = 21;
            this.lblY.Text = "Puste";
            // 
            // btnPrzesun
            // 
            this.btnPrzesun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesun.Location = new System.Drawing.Point(156, 107);
            this.btnPrzesun.Name = "btnPrzesun";
            this.btnPrzesun.Size = new System.Drawing.Size(135, 65);
            this.btnPrzesun.TabIndex = 22;
            this.btnPrzesun.Text = "Przesuń figury do nowej lokalizacji";
            this.btnPrzesun.UseVisualStyleBackColor = true;
            this.btnPrzesun.Click += new System.EventHandler(this.btnPrzesun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "0";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCofnij
            // 
            this.btnCofnij.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnij.Location = new System.Drawing.Point(15, 107);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(135, 65);
            this.btnCofnij.TabIndex = 23;
            this.btnCofnij.Text = "Cofnij ostatnią figure";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbOpcjeManual
            // 
            this.gbOpcjeManual.Controls.Add(this.txtIndex);
            this.gbOpcjeManual.Controls.Add(this.label4);
            this.gbOpcjeManual.Controls.Add(this.btnPoprzednia);
            this.gbOpcjeManual.Controls.Add(this.btnNastepna);
            this.gbOpcjeManual.Enabled = false;
            this.gbOpcjeManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOpcjeManual.Location = new System.Drawing.Point(270, 551);
            this.gbOpcjeManual.Name = "gbOpcjeManual";
            this.gbOpcjeManual.Size = new System.Drawing.Size(307, 158);
            this.gbOpcjeManual.TabIndex = 24;
            this.gbOpcjeManual.TabStop = false;
            this.gbOpcjeManual.Text = "Opcje manualne slajdera";
            // 
            // gbOpcjefigur
            // 
            this.gbOpcjefigur.Controls.Add(this.btnPrzesun);
            this.gbOpcjefigur.Controls.Add(this.btnWlaczenieSlajdera);
            this.gbOpcjefigur.Controls.Add(this.btnCofnij);
            this.gbOpcjefigur.Controls.Add(this.btnWylaczenieSlajdera);
            this.gbOpcjefigur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOpcjefigur.Location = new System.Drawing.Point(600, 531);
            this.gbOpcjefigur.Name = "gbOpcjefigur";
            this.gbOpcjefigur.Size = new System.Drawing.Size(305, 184);
            this.gbOpcjefigur.TabIndex = 25;
            this.gbOpcjefigur.TabStop = false;
            this.gbOpcjefigur.Text = "Opcje figur";
            // 
            // gbInneOpcje
            // 
            this.gbInneOpcje.Controls.Add(this.btnWczytanieBitmapa);
            this.gbInneOpcje.Controls.Add(this.btnPowrot);
            this.gbInneOpcje.Controls.Add(this.btnZapisBitmapa);
            this.gbInneOpcje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbInneOpcje.Location = new System.Drawing.Point(950, 531);
            this.gbInneOpcje.Name = "gbInneOpcje";
            this.gbInneOpcje.Size = new System.Drawing.Size(298, 184);
            this.gbInneOpcje.TabIndex = 26;
            this.gbInneOpcje.TabStop = false;
            this.gbInneOpcje.Text = "Inne opcje";
            // 
            // KreslenieFigur_Linii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 727);
            this.Controls.Add(this.gbInneOpcje);
            this.Controls.Add(this.gbOpcjefigur);
            this.Controls.Add(this.gbOpcjeManual);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbTrybPokazu);
            this.Controls.Add(this.gbAtrybutyGraficzne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFigury_Linie);
            this.Controls.Add(this.pbRysownica);
            this.Name = "KreslenieFigur_Linii";
            this.Text = "Kreślenie figur i linii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KreslenieFigur_Linii_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KreslenieFigur_Linii_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gbFigury_Linie.ResumeLayout(false);
            this.gbFigury_Linie.PerformLayout();
            this.gbAtrybutyGraficzne.ResumeLayout(false);
            this.gbAtrybutyGraficzne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSuwakGrubosci)).EndInit();
            this.gbTrybPokazu.ResumeLayout(false);
            this.gbTrybPokazu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbOpcjeManual.ResumeLayout(false);
            this.gbOpcjeManual.PerformLayout();
            this.gbOpcjefigur.ResumeLayout(false);
            this.gbInneOpcje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.GroupBox gbFigury_Linie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.Button btnWlaczenieSlajdera;
        private System.Windows.Forms.Button btnWylaczenieSlajdera;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Button btnZapisBitmapa;
        private System.Windows.Forms.Button btnWczytanieBitmapa;
        private System.Windows.Forms.GroupBox gbAtrybutyGraficzne;
        private System.Windows.Forms.GroupBox gbTrybPokazu;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtKolorWypelnienia;
        private System.Windows.Forms.TextBox txtKolorLinii;
        private System.Windows.Forms.Button btnKolorWypelnienia;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.RadioButton rdbProstokat;
        private System.Windows.Forms.RadioButton rdbKolo;
        private System.Windows.Forms.RadioButton rdbOkrag;
        private System.Windows.Forms.RadioButton rdbElipsa;
        private System.Windows.Forms.RadioButton rdbLinia;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.TrackBar trbSuwakGrubosci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.Button btnPrzesun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdbLiniaKreslonaMysza;
        private System.Windows.Forms.RadioButton rdbKrzywaBeziera;
        private System.Windows.Forms.RadioButton rdbDrawPie;
        private System.Windows.Forms.RadioButton rdbForemny;
        private System.Windows.Forms.RadioButton rdbKwadrat;
        private System.Windows.Forms.GroupBox gbOpcjeManual;
        private System.Windows.Forms.GroupBox gbOpcjefigur;
        private System.Windows.Forms.GroupBox gbInneOpcje;
    }
}
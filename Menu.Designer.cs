namespace Projekt3
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrezentacja = new System.Windows.Forms.Button();
            this.btnKreslenie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrezentacja
            // 
            this.btnPrezentacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrezentacja.Location = new System.Drawing.Point(266, 245);
            this.btnPrezentacja.Name = "btnPrezentacja";
            this.btnPrezentacja.Size = new System.Drawing.Size(196, 105);
            this.btnPrezentacja.TabIndex = 0;
            this.btnPrezentacja.Text = "Prezentacja figur ze slajderem";
            this.btnPrezentacja.UseVisualStyleBackColor = true;
            this.btnPrezentacja.Click += new System.EventHandler(this.btnPrezentacja_Click);
            // 
            // btnKreslenie
            // 
            this.btnKreslenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreslenie.Location = new System.Drawing.Point(652, 245);
            this.btnKreslenie.Name = "btnKreslenie";
            this.btnKreslenie.Size = new System.Drawing.Size(196, 105);
            this.btnKreslenie.TabIndex = 1;
            this.btnKreslenie.Text = "Kreślenie figur i linii";
            this.btnKreslenie.UseVisualStyleBackColor = true;
            this.btnKreslenie.Click += new System.EventHandler(this.btnKreslenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 623);
            this.Controls.Add(this.btnKreslenie);
            this.Controls.Add(this.btnPrezentacja);
            this.Name = "Form1";
            this.Text = "Wieloformularzowy prezenter figur geometrycznych";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrezentacja;
        private System.Windows.Forms.Button btnKreslenie;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie nowej przestrzeni nazw klasy FiguryGeometryczne, która udostępni deklaracje klas: Punkt, Linia, Elipsa itd.
using static Projekt3.FiguryGeometryczne;
//udostępnienie przestrzeni nazwdla potrzeb grafiki 2d
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Projekt3
{
    public partial class KreslenieFigur_Linii : Form
    {
        //deklaracje pomocnicze 
        const ushort Margines = 10;
        const ushort MarginesFormularza = 20;
        //deklaracja powierzchni graficznej
        Graphics Rysownica;
        Graphics RysownicaTymczasowa;
        Point Punkt;
        Pen Pioro;
        SolidBrush Pedzel;
        Pen PioroTymczasowe;
        List<Punkt> LFG = new List<Punkt>();
        public KreslenieFigur_Linii()
        {
            InitializeComponent();
            //lokalizacja i wymiarowanie
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + MarginesFormularza, Screen.PrimaryScreen.Bounds.Y + 2 * MarginesFormularza);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.7F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.75F);
            this.StartPosition = FormStartPosition.Manual;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //lokalizacja i zwymiarowanie
            pbRysownica.Location = new Point(Left + MarginesFormularza, Top + MarginesFormularza);
            pbRysownica.Width = (int)(this.Width * 0.7F);
            pbRysownica.Height = (int)(this.Height * 0.6F);
            pbRysownica.BackColor = Color.Beige;
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            gbFigury_Linie.Location = new Point(pbRysownica.Left + pbRysownica.Width + Margines, pbRysownica.Top);
            gbAtrybutyGraficzne.Location = new Point(gbFigury_Linie.Left, gbFigury_Linie.Top + gbFigury_Linie.Height + Margines);
            gbTrybPokazu.Location = new Point(pbRysownica.Left, pbRysownica.Bottom + 3 * MarginesFormularza);
            gbOpcjeManual.Location = new Point(gbTrybPokazu.Right + 2 * MarginesFormularza, pbRysownica.Bottom + 2 * MarginesFormularza);
            gbOpcjefigur.Location = new Point(gbOpcjeManual.Right + MarginesFormularza, pbRysownica.Bottom + MarginesFormularza);
            gbInneOpcje.Location = new Point(gbAtrybutyGraficzne.Left, gbOpcjefigur.Top);
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            RysownicaTymczasowa = pbRysownica.CreateGraphics();
            //utworzenie egzemplarza pióra głównego
            Punkt = Point.Empty;
            Pioro = new Pen(Color.Black, 1F);
            Pioro.DashStyle = DashStyle.Solid;
            Pioro.StartCap = LineCap.Round;
            Pioro.EndCap = LineCap.Round;
            PioroTymczasowe = new Pen(Color.Blue, 1);
            Pedzel = new SolidBrush(Color.Blue);
        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            //wypisanie współrzędnych x i y położenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                Pioro.Color = txtKolorLinii.BackColor;
                Pioro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                Pioro.Width = trbSuwakGrubosci.Value;
                Punkt = e.Location;
                if (rdbLiniaKreslonaMysza.Checked)
                {
                    //LFG.Add(new LiniaKreslonaMysza(Punkt));                    
                    LFG.Add(new LiniaKreslonaMysza(Punkt, Pioro.Color, Pioro.DashStyle, (int)Pioro.Width));
                }
            }
            pbRysownica.Refresh();
        }

        DashStyle WybranyStylLinii (int i)
        {
            switch (i)
            {
                case 0: return DashStyle.Solid;
                case 1: return DashStyle.Dash;
                case 2: return DashStyle.DashDot;
                case 3: return DashStyle.DashDotDot;
                case 4: return DashStyle.Dot;
                default: return DashStyle.Solid;
            }
        }
        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            //wypisanie współrzędnych x i y położenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            //wyznaczenie parametrów opisujących prostokąt w którym będzie wykreślana figura
            int lewyGornyNaroznikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int lewyGornyNaroznikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokosc = Math.Abs(Punkt.X - e.Location.X);
            int Wysokosc = Math.Abs(Punkt.Y - e.Location.Y);
            float poczkat = 10.0F;
            float zawikat = 45.0F; 

            //rozpoznanie czy zdarzenie MouseUp dotyczy lewego przycisku myszy
            if (e.Button == MouseButtons.Left)
            {
                if (rdbPunkt.Checked)
                {
                    LFG.Add(new Punkt(Punkt.X, Punkt.Y));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbLinia.Checked)
                {
                    LFG.Add(new Linia(Punkt.X, Punkt.Y, e.Location.X, e.Location.Y));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbElipsa.Checked)
                {
                    LFG.Add(new Elipsa(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbOkrag.Checked)
                {
                    LFG.Add(new Okrag(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbKolo.Checked)
                {
                    LFG.Add(new Kolo(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorWypelnienia.BackColor);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbLiniaKreslonaMysza.Checked)
                {
                    ((LiniaKreslonaMysza)LFG[LFG.Count - 1]).DodajNowyPunktKreslonejLinii(e.Location);
                    Rysownica.DrawLine(Pioro, Punkt, e.Location);
                }
                if (rdbProstokat.Checked)
                {
                    LFG.Add(new Prostokat(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbKwadrat.Checked)
                {
                    LFG.Add(new Kwadrat(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbDrawPie.Checked)
                {
                    LFG.Add(new RysujPie(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc, poczkat, zawikat));
                    LFG[LFG.Count - 1].UstalNoweAtrybutyGraficzne(txtKolorLinii.BackColor, WybranyStylLinii(cmbStylLinii.SelectedIndex), trbSuwakGrubosci.Value);
                    LFG[LFG.Count - 1].Wykresl(Rysownica);
                }
                if (rdbKrzywaBeziera.Checked)
                {
                    if (gbFigury_Linie.Enabled)
                    {
                        LFG.Add(new KrzywaBeziera(Rysownica, Pioro, Punkt)); //Punkt = e.Location
                        gbFigury_Linie.Enabled = false;
                        btnCofnij.Enabled = false;
                        gbOpcjefigur.Enabled = false;
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych = 0;
                    }
                    else
                    {
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).DodajNowyPunktKontrolny(e.Location, Rysownica);
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych++;
                        if (((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktowKontrolnych == 3)
                        {
                            gbFigury_Linie.Enabled = true;
                            btnCofnij.Enabled = true;
                            gbOpcjefigur.Enabled = true;
                            LFG[LFG.Count - 1].Wykresl(Rysownica);
                            //((KrzywaBeziera)LFG[LFG.Count - 1]).Wykresl(Rysownica);
                        }
                    }
                }
            }
            pbRysownica.Refresh();
        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wypisanie współrzędnych x i y położenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                lblX.Text = e.Location.X.ToString();
                lblY.Text = e.Location.Y.ToString();
                int lewyGornyNaroznikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
                int lewyGornyNaroznikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
                int Szerokosc = Math.Abs(Punkt.X - e.Location.X);
                int Wysokosc = Math.Abs(Punkt.Y - e.Location.Y);                
                if (rdbLinia.Checked)
                    RysownicaTymczasowa.DrawLine(PioroTymczasowe, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                if (rdbElipsa.Checked)
                    RysownicaTymczasowa.DrawEllipse(PioroTymczasowe, new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                if (rdbOkrag.Checked)
                    RysownicaTymczasowa.DrawEllipse(PioroTymczasowe, new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Szerokosc));
                if (rdbKolo.Checked)
                    RysownicaTymczasowa.DrawEllipse(PioroTymczasowe, new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Szerokosc));
                if (rdbProstokat.Checked)
                    RysownicaTymczasowa.DrawRectangle(PioroTymczasowe, new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Wysokosc));
                if (rdbKwadrat.Checked)
                    RysownicaTymczasowa.DrawRectangle(PioroTymczasowe, new Rectangle(lewyGornyNaroznikX, lewyGornyNaroznikY, Szerokosc, Szerokosc));
                if (rdbDrawPie.Checked)
                    RysownicaTymczasowa.DrawLine(PioroTymczasowe, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                //rozpoznanie czy kreślimy linie myszą
                if (rdbLiniaKreslonaMysza.Checked)
                {
                    ((LiniaKreslonaMysza)LFG[LFG.Count - 1]).DodajNowyPunktKreslonejLinii(e.Location);
                    Rysownica.DrawLine(Pioro, Punkt, e.Location);
                    Punkt = e.Location;
                }
                
            }
            pbRysownica.Refresh();
        }

        

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            //odszukanie formularza głównego w kolekcji OpenForms
            foreach (Form FormX in Application.OpenForms)
                //sprawdzenie czy znaleziony formularz FormX jest formularzem głównym
                if (FormX.Name == "Menu")
                {
                    //ukrycie bierzącego formularza
                    Hide();
                    //odsłonięcie formularza FormX
                    FormX.Show();
                    //wyjście z metody obsługi zdarzenia Click: btnPowrot
                    return;
                }
            //formularz główny nie został znaleziony więc go tworzymy
            Menu FormGlowny = new Menu();
            //ukrycie bierzącego formularza
            Hide();
            //odsłonięcie formularza FormX
            FormGlowny.Show();
        }

        private void KreslenieFigur_Linii_FormClosed(object sender, FormClosedEventArgs e)
        {
            //zamknięcie programu
            Application.Exit();
        }

        private void KreslenieFigur_Linii_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Wynik = MessageBox.Show("Czy rzeczywiście chcesz zakończyć działanie programu?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);
            //sprawdzenie odpowiedzi użytkowanika
            if (Wynik != DialogResult.Yes)
                //skasowanie obsługi zdarzenia Cancel
                e.Cancel = true;
            else//zdarzenie Cancel nie może być skasowane
                e.Cancel = false;
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog KolorDialog = new ColorDialog();
            KolorDialog.Color = Pioro.Color;
            if(KolorDialog.ShowDialog() == DialogResult.OK)
            {
                txtKolorLinii.BackColor = KolorDialog.Color;
                Pioro.Color = KolorDialog.Color;
            }
            KolorDialog.Dispose();
        }

        private void btnKolorWypelnienia_Click(object sender, EventArgs e)
        {
            ColorDialog KolorDialog = new ColorDialog();
            KolorDialog.Color = Pioro.Color;
            if(KolorDialog.ShowDialog() == DialogResult.OK)
            {
                txtKolorWypelnienia.BackColor = KolorDialog.Color;
                Pedzel.Color = KolorDialog.Color;
            }
            KolorDialog.Dispose();
        }

        private void btnPrzesun_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int X, Y;
            Random rnd = new Random();
            for (int i = 0; i < LFG.Count; i++)
            {
                X = rnd.Next(Margines, Xmax - Margines);
                Y = rnd.Next(Margines, Xmax - Margines);
                LFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, X - 2 * Margines, Y - 2 * Margines);                
                LFG[i].Wykresl(Rysownica);
            }
            pbRysownica.Refresh();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            if (LFG.Count <= 0)
            {
                errorProvider1.SetError(btnCofnij, "ERROR: lista figur jest pusta");
                return;
            }
            LFG.RemoveAt(LFG.Count - 1);
            Rysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < LFG.Count; i++)
            {
                LFG[i].Wykresl(Rysownica);
            }
            pbRysownica.Refresh();
            errorProvider1.Dispose();
        }

        private void rdbKrzywaBeziera_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKrzywaBeziera.Checked)
            MessageBox.Show("Wykreślenie Krzywej Beziera wymaga zaznaczenia (kliknięciem) 4 punktów na powierzchni graficznej: Rysownicy", "Krzywa Beziera", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            //deklaracja pomocnicza
            ushort IndeksFigury;
            IndeksFigury = ushort.Parse(txtIndex.Text);
            if (IndeksFigury < LFG.Count - 1)
                IndeksFigury++;
            else
                IndeksFigury = 0;
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            LFG[IndeksFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
            txtIndex.Text = IndeksFigury.ToString();
        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            ushort IndeksFigury;
            //obranie numeru indeksu TFG wpisanego do kontrolki textbox
            if (!ushort.TryParse(txtIndex.Text, out IndeksFigury))
            {
                errorProvider1.SetError(txtIndex, "ERROR: w zapisie indeksu figury wystąpił niedozwolony znak");
                return;
            }
            else
                errorProvider1.Dispose();
            if (IndeksFigury >= LFG.Count)
            {
                errorProvider1.SetError(txtIndex, "ERROR: przekroczenie dopuszczalnej wartości indeksu, maksymalny indeks = " + (LFG.Count - 1));
                return;
            }
            else
                errorProvider1.Dispose();
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            LFG[IndeksFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            //deklaracja pomocnicza
            ushort IndeksFigury;
            IndeksFigury = ushort.Parse(txtIndex.Text);
            if (IndeksFigury < LFG.Count & IndeksFigury != 0)
                IndeksFigury--;
            else
                IndeksFigury = (ushort)(LFG.Count - 1);
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            LFG[IndeksFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
            txtIndex.Text = IndeksFigury.ToString();
        }

        private void btnWlaczenieSlajdera_Click(object sender, EventArgs e)
        {
            if (LFG.Count <= 0)
            {
                errorProvider1.SetError(btnWlaczenieSlajdera, "ERROR: lista figur jest pusta");
                return;
            }
            errorProvider1.Dispose();
            //wyczyszczenie Rysownicy
            Rysownica.Clear(pbRysownica.BackColor);
            //ustawienie indeksu TFG dla pokazu pierwszej figury
            timer1.Tag = 0;
            txtIndex.Text = 0.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            LFG[0].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
            if (rdbAutomatyczny.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                gbOpcjeManual.Enabled = true;
                btnNastepna.Enabled = true;
                btnPoprzednia.Enabled = true;
                txtIndex.Enabled = true;
            }
            btnWlaczenieSlajdera.Enabled = false;
            btnCofnij.Enabled = false;
            btnPrzesun.Enabled = false;
            btnWylaczenieSlajdera.Enabled = true;
            errorProvider1.Dispose();
        }

        private void btnWylaczenieSlajdera_Click(object sender, EventArgs e)
        {
            //wyczyszczenie rysownicy
            Rysownica.Clear(pbRysownica.BackColor);
            //wyłączenie zegara
            timer1.Enabled = false;
            //wyczyszczenie kontrolki
            txtIndex.Text = null;
            //uaktywnienie przycisku poleceń
            btnWlaczenieSlajdera.Enabled = true;
            btnPrzesun.Enabled = true;
            btnCofnij.Enabled = true;
            //ustawienie stanu braku aktywności
            btnWylaczenieSlajdera.Enabled = false;
            rdbAutomatyczny.Checked = true;
            gbOpcjeManual.Enabled = false;
            btnNastepna.Enabled = false;
            btnPoprzednia.Enabled = false;
            txtIndex.Enabled = false;
            //wykreslenie wszystkich figur z tfg w losowo określonej lokalizacji
            Random rnd = new Random();
            int x, y;
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            for (int i = 0; i < LFG.Count; i++)
            {
                x = rnd.Next(Margines, Xmax - Margines);
                y = rnd.Next(Margines, Ymax - Margines);
                LFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, x, y);
            }
            pbRysownica.Refresh();
            errorProvider1.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wymazanie całej powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiaru powierzchni graficznej
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //wpisanie od kontrolki slajder indeksu TFG figury
            txtIndex.Text = timer1.Tag.ToString();
            //wykreślenie figury o indeksie timer1.tag
            LFG[(int)(timer1.Tag)].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            //odświerzenie powierzchni
            pbRysownica.Refresh();
            //ustawienie indeksu dla następnej figury
            timer1.Tag = (int.Parse(timer1.Tag.ToString()) + 1) % (LFG.Count);
        }

        private void btnZapisBitmapa_Click(object sender, EventArgs e)
        {
            SaveFileDialog bitmapa = new SaveFileDialog();
            bitmapa.Filter = "png files (*.png)| *.png | All files(*.*) | *.*";
            bitmapa.InitialDirectory = "C:\\";
            if (bitmapa.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.Image.Save(bitmapa.FileName, ImageFormat.Png);
            }
        }

        private void btnWczytanieBitmapa_Click(object sender, EventArgs e)
        {
            OpenFileDialog bitmapa = new OpenFileDialog();
            bitmapa.Filter = "All files(*.*) | *.*";
            bitmapa.InitialDirectory = "C:\\";
            if (bitmapa.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.BackgroundImage = Image.FromFile(bitmapa.FileName);
                
            }
        }
    }
}

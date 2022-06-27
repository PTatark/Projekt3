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

namespace Projekt3
{
    public partial class PrezentacjaLosowaZeSlajderem : Form
    {
        //deklaracja powierzchni graficznej
        Graphics Rysownica;
        //deklaracja zmiennej tablicowej (referencyjnej) TFG: tablica figur geometrycznych
        Punkt[] TFG;
        int IndexTFG; //indeks tablicy TFG
        //deklaracje stałych pomocniczych
        const int Marginesformularza = 20;
        const int Margines = 10;

        public PrezentacjaLosowaZeSlajderem()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + Marginesformularza, Screen.PrimaryScreen.Bounds.Y + Marginesformularza);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.70F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.65F);
            //lokalizacja i zwymiarowanie formularza według podanych ustawień
            this.StartPosition = FormStartPosition.Manual;
            //ustawienie stanu braku aktywności dla przycisków Maksymalizacji i Minimalizacji
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //lokalizacja i zwymiarowanie kontrolek umieszczonych na formularzu
            lblN.Location = new Point(Left + Margines, Top + Margines);
            txtN.Location = new Point(lblN.Left + Marginesformularza, lblN.Top + lblN.Height + Marginesformularza);
            btnStart.Location = new Point (lblN.Left, txtN.Top + txtN.Height + Marginesformularza);
            btnPrzesun.Location = new Point(lblN.Left, btnStart.Bottom + Marginesformularza);
            btnAtrybutyGeo.Location = new Point(lblN.Left, btnPrzesun.Bottom + Marginesformularza);
            btnWlaczenieSlajdera.Location = new Point(lblN.Left, btnAtrybutyGeo.Bottom + Marginesformularza);
            btnWylaczenieSlajdera.Location = new Point(lblN.Left, btnWlaczenieSlajdera.Bottom + Marginesformularza);
            //lokalizacja kontrolkji Picturebox
            pbRysownica.Location = new Point(btnStart.Left + btnStart.Width + Marginesformularza, txtN.Top);
            pbRysownica.Width = (int)(this.Width * 0.6F);
            pbRysownica.Height = (int)(this.Height * 0.6F);
            //ustalenie koloru tła kontrolki Picturebox
            pbRysownica.BackColor = Color.Beige;
            //ustalenie obramowania kontrolki Picturebox
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            //utworzenie mapy bitowej i podpięcie jej do kontrolki Picturebox
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //lokalizacja kontrolki checkslistbox
            chbFiguryGeometryczne.Location = new Point(pbRysownica.Left + pbRysownica.Width + Marginesformularza, pbRysownica.Top + Marginesformularza * 3);
            //lokalizacja kontrolki powrotu
            btnPowrot.Location = new Point(pbRysownica.Left + pbRysownica.Width + Marginesformularza, lblN.Top);
            //lokalizacja groupboxów
            gbTrybPokazu.Location = new Point(pbRysownica.Left, pbRysownica.Bottom + Marginesformularza * 2);
            gbOpcjeManual.Location = new Point(gbTrybPokazu.Right + Marginesformularza * 2, pbRysownica.Bottom + Marginesformularza);
            //utworzenie egzemplarza powierzchni graficznej
            Rysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //pełna deklaracja metody obsługi przycisku poleceń Start
            //deklaracja zmiennej dla przechowania podanej liczby figur
            ushort N;
            //zgaszenie komponentu errorProvider1
            errorProvider1.Dispose();
            //pobranie liczby figur geometrycznych do prezentacji
            //sprawdzenie czy została podana liczba figur
            if(string.IsNullOrEmpty(txtN.Text.Trim()))
            {
                //sygnalizacja błedu
                errorProvider1.SetError(txtN, "ERROR: musisz podać liczbę figur geometrycznych do prezentacji");
                return;
            }
            //pobranie wpisanej liczby figur
            if (!ushort.TryParse(txtN.Text, out N))
            {
                //błąd
                errorProvider1.SetError(txtN, "ERROR: w zapisie liczby figur wystąpił niedozwolony znak");
                return;
            }
            //utworzenie egzemplarza TFG
            TFG = new Punkt[N]; IndexTFG = 0;
            //sprawdzenie czy użytkownik zaznaczył figury
            if(chbFiguryGeometryczne.CheckedItems.Count <= 0)
            {
                //sygnalizacja błędu
                errorProvider1.SetError(chbFiguryGeometryczne, "ERROR: musisz wybrać co najmniej jedną figurę");
                return;
            }
            //skopiowanie kolekcji wybranych figur
            CheckedListBox.CheckedItemCollection WybraneFigury = chbFiguryGeometryczne.CheckedItems;
            //stan brku aktywności
            chbFiguryGeometryczne.Enabled = false;
            //wyznaczenie rozmiarów powierzchni graficznej
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //deklaracje pomocnicze
            int X, Y;
            Color KolorLinii;
            Color KolorWypełnienia;
            int GruboscLinii;
            int GruboscPunktu;
            DashStyle StylLinii;
            int Xk, Yk;
            int OsDuza, OsMala;
            int Promien;
            int WylosowanyIndexFigury;
            int Szerokosc, Wysokosc;
            //losowanie atrybutów geometrycznych i graficznych
            for (int i = 0; i < N; i++)
            {
                X = rnd.Next(Margines, Xmax - Margines);
                Y = rnd.Next(Margines, Ymax - Margines);
                //wylosowanie koloru linii
                KolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                KolorWypełnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                //wylosowanie stylu linii
                switch (rnd.Next(1, 6))
                {
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.Dot; break;
                    case 3: StylLinii = DashStyle.DashDotDot; break;
                    case 4: StylLinii = DashStyle.DashDot; break;
                    case 5: StylLinii = DashStyle.Solid; break;
                    default: StylLinii = DashStyle.Solid; break;
                }
                //wylosowanie grubości linii
                GruboscLinii = rnd.Next(1, 10);
                GruboscPunktu = rnd.Next(3, 15);
                //wylosowanie figury do utworzenia jej egzemplarza i wykreślenia
                WylosowanyIndexFigury = rnd.Next(WybraneFigury.Count);
                //rozpoznanie wylosowanej figury utworzenie jej egzemplarza i wykreślenie
                switch(WybraneFigury[WylosowanyIndexFigury].ToString())
                {
                    case "Punkt":
                        //utworzenie egzemplarza Punktu i wpisanie jego referencji do TFG
                        TFG[IndexTFG] = new Punkt(X, Y);
                        //ustalenie atrybutów geometrycznych i graficznych egzemplarzowi
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorWypełnienia, StylLinii, GruboscPunktu);
                        //wykreślenie punktu
                        TFG[IndexTFG].Wykresl(Rysownica);
                        //zwiększenie indeksu
                        IndexTFG++;
                        break;
                    case "Linia":
                        //początek linii wyznaczają współrzędne X, Y
                        Xk = rnd.Next(Margines, Xmax - Margines);
                        Yk = rnd.Next(Margines, Ymax - Margines);
                        //utworzenie egzemplarza
                        TFG[IndexTFG] = new Linia(X, Y, Xk, Yk);
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        //zwiększenie indexu
                        IndexTFG++;
                        break;
                    case "Elipsa":
                        //wylosowanie Osi dużej i małej
                        OsDuza = rnd.Next(Margines, Xmax / 4 - Margines);
                        OsMala = rnd.Next(Margines, Ymax / 4 - Margines);
                        //utworzenie egzemplarza
                        TFG[IndexTFG] = new Elipsa(X, Y, OsDuza, OsMala);
                        //ustalenie atrybutów graficznych
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                        //wykreślenie elipsy
                        TFG[IndexTFG].Wykresl(Rysownica);
                        //zwiększenie indexu
                        IndexTFG++;
                        break;
                    case "Okrąg":
                        //wylosowanie promienia
                        Promien = rnd.Next(Margines, Ymax / 4);
                        //utworzenie egzemplarza
                        TFG[IndexTFG] = new Okrag(X, Y, Promien);
                        //ustalenie atrybutów graficznych
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                        //wykreślenie okręgu
                        TFG[IndexTFG].Wykresl(Rysownica);
                        //zwiększenie indeksu
                        IndexTFG++;
                        break;
                    case "Koło":
                        //wylosowanie promienia
                        Promien = rnd.Next(Margines, Ymax / 4);
                        //utworzenie egzemplarza
                        TFG[IndexTFG] = new Kolo(X, Y, Promien);
                        //ustalenie atrybutów graficznych
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                        //wykreślenie koła
                        TFG[IndexTFG].Wykresl(Rysownica);
                        //zwiększenie indeksu
                        IndexTFG++;
                        break;
                    case "Prostokąt":
                        Szerokosc = rnd.Next(Margines, Xmax / 4);
                        Wysokosc = rnd.Next(Margines, Ymax / 4);
                        TFG[IndexTFG] = new Prostokat(X, Y, Szerokosc, Wysokosc);
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Kwadrat":
                        Szerokosc = rnd.Next(Margines, Xmax / 4);                        
                        TFG[IndexTFG] = new Kwadrat(X, Y, Szerokosc);
                        TFG[IndexTFG].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                        TFG[IndexTFG].Wykresl(Rysownica);
                        IndexTFG++;
                        break;
                    default:
                        MessageBox.Show("Wylosowana figura" + chbFiguryGeometryczne.CheckedItems[WylosowanyIndexFigury] + "nie jest jeszcze obsługiwana");
                        return;
                }
            }
            //odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            //uaktywnienie przycisków poleceń dla wykonania funkcjonalności
            btnPrzesun.Enabled = true;
            btnAtrybutyGeo.Enabled = true;
            btnWlaczenieSlajdera.Enabled = true;
            //stan braku aktywności
            btnStart.Enabled = false;
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            //odszukanie formularza głównego w kolekcji OpenForms
            foreach(Form FormX in Application.OpenForms)
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

        private void PrezentacjaLosowaZeSlajderem_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PrezentacjaLosowaZeSlajderem_FormClosed(object sender, FormClosedEventArgs e)
        {
            //zamknięcie programu
            Application.Exit();
        }

        private void btnPrzesun_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemlparza liczb losowych
            Random rnd = new Random();
            //deklaracje zmiennych pomocniczych
            int Xp, Yp;
            int Xmax, Ymax;
            //wymazanie powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiarów Rysownicy
            Xmax = pbRysownica.Width;
            Ymax = pbRysownica.Height;
            //losowanie nowego położenia dla wszystkich  figur
            for (int i = 0; i < TFG.Length; i++)
            {
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xp, Yp);
            }
            //odświerzenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnAtrybutyGeo_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza generatora liczb losowych
            Random rnd = new Random();
            int Xp, Yp;
            Color KolorLinii, KolorWypelnienia;
            int GruboscLinii;
            DashStyle StylLinii;
            int Xmax, Ymax;
            //oczyszczenie
            Rysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiarów powierzchni graficznej
            Xmax = pbRysownica.Width;
            Ymax= pbRysownica.Height;
            //losowanie atrybutów
            for(int i = 0; i < TFG.Length; i++)
            {
                //losowanie koloru linii
                KolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                //losowanie koloru wypełnienia
                KolorWypelnienia = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                //losowanie stylu linii
                switch (rnd.Next(1, 6))
                {
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.Dot; break;
                    case 3: StylLinii = DashStyle.Solid; break;
                    case 4: StylLinii = DashStyle.DashDot; break;
                    case 5: StylLinii = DashStyle.DashDotDot; break;
                    default: StylLinii= DashStyle.Solid; break;
                }
                //wylosowanie grubości linii
                GruboscLinii = rnd.Next(1, Margines);
                TFG[i].UstalNoweAtrybutyGraficzne(KolorLinii, StylLinii, GruboscLinii);
                TFG[i].UstalNoweAtrybutyGraficzne(KolorWypelnienia);
                //wylosowanie nowego położenia
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xp, Yp);
            }
            //odświerzenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wymazanie całej powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);
            //wyznaczenie rozmiaru powierzchni graficznej
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            //wpisanie od kontrolki slajder indeksu TFG figury
            txtIndexTFG.Text = timer1.Tag.ToString();
            //wykreślenie figury o indeksie timer1.tag
            TFG[(int)(timer1.Tag)].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            //odświerzenie powierzchni
            pbRysownica.Refresh();
            //ustawienie indeksu dla następnej figury
            timer1.Tag = (int.Parse(timer1.Tag.ToString()) + 1) % (TFG.Length);

        }

        private void btnWlaczenieSlajdera_Click(object sender, EventArgs e)
        {
            //wyczyszczenie Rysownicy
            Rysownica.Clear(pbRysownica.BackColor);
            //ustawienie indeksu TFG dla pokazu pierwszej figury
            timer1.Tag = 0;
            txtIndexTFG.Text = 0.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            TFG[0].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
            if (rdbAutomatyczny.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                btnNastepna.Enabled = true;
                btnPoprzednia.Enabled = true;
                txtIndexTFG.Enabled = true;
            }
            btnWlaczenieSlajdera.Enabled = false;
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
            txtIndexTFG.Text = null;
            //uaktywnienie przycisku poleceń
            btnWlaczenieSlajdera.Enabled = true;
            //ustawienie stanu braku aktywności
            btnWylaczenieSlajdera.Enabled = false;
            //ustawienie stanu braku aktywności
            rdbAutomatyczny.Checked = true;
            btnNastepna.Enabled = false;
            btnPoprzednia.Enabled = false;
            txtIndexTFG.Enabled = false;
            //wykreslenie wszystkich figur z tfg w losowo określonej lokalizacji
            Random rnd = new Random();
            int x, y;
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            for (int i = 0; i < TFG.Length; i++)
            {
                x = rnd.Next(Margines, Xmax - Margines);
                y = rnd.Next(Margines, Ymax - Margines);
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, x, y);
            }
            pbRysownica.Refresh();
            errorProvider1.Dispose();
        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            //deklaracja pomocnicza
            ushort IndeksFigury;
            IndeksFigury = ushort.Parse(txtIndexTFG.Text);
            if (IndeksFigury < TFG.Length - 1)
                IndeksFigury++;
            else
                IndeksFigury = 0;
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            TFG[IndeksFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
            txtIndexTFG.Text = IndeksFigury.ToString();
        }

        private void txtIndexTFG_TextChanged(object sender, EventArgs e)
        {
            ushort IndeksFigury;
            //obranie numeru indeksu TFG wpisanego do kontrolki textbox
            if (!ushort.TryParse(txtIndexTFG.Text, out IndeksFigury))
            {
                errorProvider1.SetError(txtIndexTFG, "ERROR: w zapisie indeksu figury wystąpił niedozwolony znak");
                return;
            }
            else
                errorProvider1.Dispose();
            if (IndeksFigury >= TFG.Length)
            {
                errorProvider1.SetError(txtIndexTFG, "ERROR: przekroczenie dopuszczalnej wartości indeksu, maksymalny indeks = " + (TFG.Length - 1));
                return;
            }
            else
                errorProvider1.Dispose();
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            TFG[IndeksFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            //deklaracja pomocnicza
            ushort IndeksFigury;
            IndeksFigury = ushort.Parse(txtIndexTFG.Text);            
            if (IndeksFigury < TFG.Length & IndeksFigury != 0)
                IndeksFigury--;
            else
                IndeksFigury = (ushort)(TFG.Length - 1);            
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            TFG[IndeksFigury].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
            txtIndexTFG.Text = IndeksFigury.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Projekt3
{
    internal class FiguryGeometryczne
    {
        public class Punkt
        {//deklaracje klasy bazowej
            const int DomyslnyRozmiarPunktu = 20;
            protected int X;
            protected int Y;
            protected Color Kolor;
            //deklaracja atrybutów wspólnych dla klas pochodnych
            protected DashStyle StylLinii;
            protected int GruboscLinii;
            protected Color KolorTla;
            protected bool Widoczny;
            //deklaracja konstruktora
            public Punkt(int x, int y)
            {
                X = x; Y = y;
                //domyślne określenie Koloru punktu
                Kolor = Color.Black;
                //domysle ustawienie wartości atrybutów dla klas pochodnych
                KolorTla = Color.White;
                StylLinii = DashStyle.Solid;
                GruboscLinii = 1;
                Widoczny = false;
            }
            //drugi konstruktor
            public Punkt (int x, int y, Color Kolor): this (x, y)
            {
                this.Kolor = Kolor;
            }
            public Punkt(int x, int y, Color Kolor, int RozmiarPunktu) : this(x, y, Kolor)
            {
                GruboscLinii = RozmiarPunktu;
            }
            public Punkt(int X, int Y, Color Kolor, DashStyle StylLinii, int RozmiarPunktu) : this(X, Y, Kolor)
            {
                this.StylLinii = StylLinii;
                this.GruboscLinii = RozmiarPunktu;
            }
            //deklaracja zmiennych prywatnych
            public virtual void UaktualnijXY (int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
            //przeciążenie metody
            private void UaktualnijXY (Point NowaLokalizacja)
            {
                X = NowaLokalizacja.X;
                Y = NowaLokalizacja.Y;
            }
            //deklaracja metod publicznych
            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, Point NowaLokalizacja)
            {
                UaktualnijXY(NowaLokalizacja);
                Wykresl(Rysownica);
            }
            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                UaktualnijXY(x, y);
                Wykresl(Rysownica);
            }
            public void UstalNoweAtrybutyGraficzne(Color Kolor, DashStyle StylLinii, int GruboscLinii)
            {
                this.Kolor = Kolor;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }
            public void UstalNoweAtrybutyGraficzne(Color KolorTla)
            {
                this.KolorTla = KolorTla;
            }
            protected void UstalStylLinii(DashStyle StylLinii)
            {
                this.StylLinii = StylLinii;
            }
            public virtual void Wykresl(Graphics Rysownica)
            {
                //deklaracja pędzla 
                SolidBrush Pedzel = new SolidBrush(Kolor);
                Rysownica.FillEllipse(Pedzel, X - DomyslnyRozmiarPunktu / 2, Y - DomyslnyRozmiarPunktu / 2, DomyslnyRozmiarPunktu, DomyslnyRozmiarPunktu);
                Widoczny = true;
                //zwolnienie pędzla
                Pedzel.Dispose();
            }
            public virtual void Wymaz(Control Kontrolka, Graphics Rysownica)
            {//deklaracja pędzla
                SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor);
                //wymazanie punktu
                Rysownica.FillEllipse(Pedzel, X - DomyslnyRozmiarPunktu / 2, Y - DomyslnyRozmiarPunktu / 2, DomyslnyRozmiarPunktu, DomyslnyRozmiarPunktu);
                this.Widoczny = false;
                //zwolnienie pędzla
                Pedzel.Dispose();
            }
        }
        public class Linia : Punkt
        {
            int Xk, Yk;
            //deklaracja konstruktora
            public Linia (int Xp, int Yp, int Xk, int Yk): base(Xp, Yp)
            {
                //przechowanie współrzędnych końca linii
                this.Xk = Xk;
                this.Yk = Yk;                
            }
            public Linia(int Xp, int Yp, int Xk, int Yk, Color Kolor, int GruboscLinii, DashStyle StylLinii) : base(Xp, Yp, Kolor, StylLinii, GruboscLinii)
            {
                //przechowanie pozostałych atrybutów
                base.GruboscLinii = GruboscLinii;
                base.StylLinii = StylLinii;
            }
            //deklaracje metod klasy linia
            //nadpisanie metod wirtualnych
            public override void Wykresl(Graphics Rysownica)
            {//wykreślenie pojedyńczej linii
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                //ustalenie stylu linii dla pióra
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                Rysownica.DrawLine(Pioro, X, Y, Xk, Yk);
                //zwolnienie pióra
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.DrawLine(Pioro, X, Y, Xk, Yk);
                //zwolnienie pióra
                Pioro.Dispose();
            }
        }
        //deklaracja klasy elipsa
        public class Elipsa : Punkt
        {
            protected int OsDuza, OsMala;
            //deklaracja konstruktorów 
            public Elipsa (int x, int y, int OsDuza, int OsMala):base(x, y)
            {
                //ustawienie pozostałych atrybutów klasy Elipsa
                this.OsDuza = OsDuza;
                this.OsMala = OsMala;
            }
            //deklaracje pozostałych konstruktorów
            public Elipsa (int x, int y, int OsDuza, int OsMala, Color Kolor, DashStyle StylLinii, int GruboscLinii) : base(x, y, Kolor, StylLinii, GruboscLinii)
            {
                this.OsDuza = OsDuza;
                this.OsMala= OsMala;
            }
            public override void Wykresl(Graphics Rysownica)
            {//wykreślenie pojedyńczej linii
                Pen Pioro = new Pen(Kolor, this.GruboscLinii);
                //ustalenie stylu linii dla pióra
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                Rysownica.DrawEllipse(Pioro, X, Y, OsDuza, OsMala);
                //zwolnienie pióra
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.DrawEllipse(Pioro, X, Y, OsDuza, OsMala);
                //zwolnienie pióra
                Pioro.Dispose();
            }
        }
        //deklaracje klasy Okrąg
        public class Okrag : Elipsa
        {
            protected int Promien;
            //deklaracja konstruktora
            public Okrag(int x, int y, int Promien):base (x, y, Promien, Promien)
            {
                this.Promien = Promien;
            }
            public Okrag(int x, int y, int Promien, Color Kolor, DashStyle StylLinii, int GruboscLinii) : base(x, y, Promien, Promien, Kolor, StylLinii, GruboscLinii)
            {
                this.Promien = Promien;
            }
            public override void Wykresl(Graphics Rysownica)
            {//wykreślenie pojedyńczej linii
                Pen Pioro = new Pen(Kolor, this.GruboscLinii);
                //ustalenie stylu linii dla pióra
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                Rysownica.DrawEllipse(Pioro, X, Y, Promien, Promien);
                //zwolnienie pióra
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.DrawEllipse(Pioro, X, Y, Promien, Promien);
                //zwolnienie pióra
                Pioro.Dispose();
            }
        }
        public class Kolo : Okrag
        {
            public Kolo(int x, int y, int Promien) : base(x, y, Promien)
            {
                this.Promien = Promien;
            }
            public Kolo(int x, int y, int Promien, Color KolorTla, DashStyle StylLinii, int GruboscLinii) : base(x, y, Promien, KolorTla, StylLinii, GruboscLinii)
            {
                this.Promien = Promien;
            }
            public override void Wykresl(Graphics Rysownica)
            {//wykreślenie pojedyńczej linii
                SolidBrush Pedzel = new SolidBrush(KolorTla);
                //wykreślenie linii
                Rysownica.FillEllipse(Pedzel, X, Y, Promien, Promien);
                //zwolnienie pióra
                Pedzel.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor);
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.FillEllipse(Pedzel, X, Y, Promien, Promien);
                //zwolnienie pióra
                Pedzel.Dispose();
            }
        }
        public class Prostokat : Punkt
        {
            protected int Szerokosc, Wysokosc;
            public Prostokat(int x, int y, int Szerokosc, int Wysokosc) :base (x, y)
            {
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }
            public Prostokat(int x, int y, int Szerokosc, int Wysokosc, Color Kolor, DashStyle StylLinii, int GruboscLinii) : base(x, y, Kolor, StylLinii, GruboscLinii)
            {
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                //wykreślenie pojedyńczej linii
                Pen Pioro = new Pen(Kolor, this.GruboscLinii);
                //ustalenie stylu linii dla pióra
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                Rysownica.DrawRectangle(Pioro, X, Y, Szerokosc, Wysokosc);
                //zwolnienie pióra
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.DrawRectangle(Pioro, X, Y, Szerokosc, Wysokosc);
                //zwolnienie pióra
                Pioro.Dispose();
            }
        }
        public class Kwadrat : Prostokat
        {
            public Kwadrat(int x, int y, int Szerokosc) : base(x, y, Szerokosc, Szerokosc)
            {
                this.Szerokosc = Szerokosc;                
            }
            public Kwadrat(int x, int y, int Szerokosc, Color Kolor, DashStyle StylLinii, int GruboscLinii) : base(x, y, Szerokosc, Szerokosc, Kolor, StylLinii, GruboscLinii)
            {
                this.Szerokosc = Szerokosc;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                //wykreślenie pojedyńczej linii
                Pen Pioro = new Pen(Kolor, this.GruboscLinii);
                //ustalenie stylu linii dla pióra
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                Rysownica.DrawRectangle(Pioro, X, Y, Szerokosc, Szerokosc);
                //zwolnienie pióra
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.DrawRectangle(Pioro, X, Y, Szerokosc, Szerokosc);
                //zwolnienie pióra
                Pioro.Dispose();
            }
        }
        public class WielokatForemny : Punkt
        {
            protected int Szerokosc;
            public WielokatForemny(int x, int y, int Szerokosc) : base(x, y)
            {
                this.Szerokosc = Szerokosc;
            }
            public WielokatForemny(int x, int y, int Szerokosc, Color KolorTla, DashStyle StylLinii, int GruboscLinii) : base(x, y, KolorTla, StylLinii, GruboscLinii)
            {
                this.Szerokosc = Szerokosc;
            }
            public override void Wykresl(Graphics Rysownica)
            {//wykreślenie pojedyńczej linii
                SolidBrush Pedzel = new SolidBrush(KolorTla);
                //wykreślenie linii
                Rysownica.FillEllipse(Pedzel, X, Y, Szerokosc, Szerokosc);
                //zwolnienie pióra
                Pedzel.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor);
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.FillEllipse(Pedzel, X, Y, Szerokosc, Szerokosc);
                //zwolnienie pióra
                Pedzel.Dispose();
            }
        }
        public class RysujPie : Prostokat
        {
            protected float poczkat, zawikat;
            public RysujPie(int x, int y, int Szerokosc, int Wysokosc, float poczkat, float zawikat) : base(x, y, Szerokosc, Wysokosc)
            {
                this.Szerokosc= Szerokosc;
                this.Wysokosc= Wysokosc;
                this.poczkat = poczkat;
                this.zawikat = zawikat;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                try
                {
                    //wykreślenie pojedyńczej linii
                    Pen Pioro = new Pen(Kolor, this.GruboscLinii);
                    //ustalenie stylu linii dla pióra
                    Pioro.DashStyle = StylLinii;
                    //wykreślenie linii
                    Rysownica.DrawPie(Pioro, X, Y, Szerokosc, Wysokosc, poczkat, zawikat);
                    //zwolnienie pióra
                    Pioro.Dispose();
                }
                catch 
                {
                    Szerokosc = 200;
                    Wysokosc = 150;
                    //wykreślenie pojedyńczej linii
                    Pen Pioro = new Pen(Kolor, this.GruboscLinii);
                    //ustalenie stylu linii dla pióra
                    Pioro.DashStyle = StylLinii;
                    //wykreślenie linii
                    Rysownica.DrawPie(Pioro, X, Y, Szerokosc, Wysokosc, poczkat, zawikat);
                    //zwolnienie pióra
                    Pioro.Dispose();
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                //ustawienie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie pióra w Kolorze tła kontrolki na powierzchni której jest wykreślona linia
                Rysownica.DrawPie(Pioro, X, Y, Szerokosc, Wysokosc, poczkat, zawikat);
                //zwolnienie pióra
                Pioro.Dispose();
            }
        }
        
        public class LiniaKreslonaMysza : Punkt
        {
            //deklaracja listy punktów linii ciągłej
            List<Point> ListaPunktow = new List<Point>();
            //deklaracja konstruktorów klasy
            public LiniaKreslonaMysza(Point PoczatekLinii) : base(PoczatekLinii.X, PoczatekLinii.Y)
            {
                ListaPunktow.Add(PoczatekLinii);
            }
            public LiniaKreslonaMysza(Point PoczatekLinii, Color Kolor, DashStyle StylLinii, int GruboscLinii) : base(PoczatekLinii.X, PoczatekLinii.Y, Kolor, StylLinii, GruboscLinii)
            {
                ListaPunktow.Add(PoczatekLinii);
            }
            //deklaracje metod
            public void DodajNowyPunktKreslonejLinii(Point NowyPunkt)
            {
                ListaPunktow.Add(NowyPunkt);
            }
            public override void UaktualnijXY(int x, int y)
            {
                if (ListaPunktow.Count < 1)
                    return;
                int PrzyrostX = ListaPunktow[0].X - x;
                int PrzyrostY = ListaPunktow[0].Y - y;
                for (int i = 0; i < ListaPunktow.Count; i++)
                    ListaPunktow[i] = new Point(ListaPunktow[i].X - PrzyrostX, ListaPunktow[i].Y - PrzyrostY);
            }
            public override void Wykresl(Graphics Rysownica)
            {
                Point[] TablicaPunktow = new Point[ListaPunktow.Count];
                for (int i = 0; i < ListaPunktow.Count; i++)
                    TablicaPunktow[i] = ListaPunktow[i];
                Pen Pioro = new Pen(Kolor, GruboscLinii);
                Pioro.DashStyle = StylLinii;
                Rysownica.DrawLines(Pioro, TablicaPunktow);
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                Point[] TablicaPunktow = new Point[ListaPunktow.Count];
                for (int i = 0; i < ListaPunktow.Count; i++)
                    TablicaPunktow[i] = ListaPunktow[i];
                Pen PioroGumka = new Pen(Kontrolka.BackColor, GruboscLinii);
                PioroGumka.DashStyle = StylLinii;
                Rysownica.DrawLines(PioroGumka, TablicaPunktow);
            }
        }
        public class KrzywaBeziera: Punkt
        {
            public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();
            int PromienPunktuKontrolnego = 5;
            public ushort LiczbaPunktowKontrolnych
            {
                get;
                set;
            }
            Font FontOpisuPunktow = new Font("Arial", 9, FontStyle.Italic);
            public KrzywaBeziera(Graphics Rysownica, Pen Pioro, Point XYpunktu) : base(XYpunktu.X, XYpunktu.Y, Pioro.Color, Pioro.DashStyle, (int)Pioro.Width)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Pioro.Color))
                {
                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - PromienPunktuKontrolnego, XYpunktu.Y - PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego);
                    Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktow, Pedzel, PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                }
            }
            public void DodajNowyPunktKontrolny (Point XYpunktu, Graphics Rysownica)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunktu);
                using (SolidBrush Pedzel = new SolidBrush(Color.Red))
                {
                    if ((PunktyKontrolneKrzywejBeziera.Count == 1) || (PunktyKontrolneKrzywejBeziera.Count == 4))
                    {
                        Pedzel.Color = Kolor;
                    }

                    Rysownica.FillEllipse(Pedzel, XYpunktu.X - PromienPunktuKontrolnego, XYpunktu.Y - PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego, 2 * PromienPunktuKontrolnego);
                    Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktow, Pedzel, PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);
                }
                if (PunktyKontrolneKrzywejBeziera.Count == 4)
                    Wykresl(Rysownica);
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];
                    for (ushort i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                        PunktyKontrolne[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X, PunktyKontrolneKrzywejBeziera[i].Y);
                    Rysownica.DrawBezier(Pioro, PunktyKontrolne[0], PunktyKontrolne[1], PunktyKontrolne[2], PunktyKontrolne[3]);
                    Widoczny = true;
                    Pioro.Dispose();
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                using(Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Point[] PunktyKrzywejBeziera = new Point[PunktyKontrolneKrzywejBeziera.Count];
                    for (int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                    {
                        PunktyKrzywejBeziera[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X, PunktyKontrolneKrzywejBeziera[i].Y);
                    }

                    Rysownica.DrawBezier(Pioro, PunktyKrzywejBeziera[0], PunktyKrzywejBeziera[1], PunktyKrzywejBeziera[2], PunktyKrzywejBeziera[3]);
                    Widoczny = false;
                }
            }
            public override void UaktualnijXY(int X, int Y)
            {
                int PrzyrostX = PunktyKontrolneKrzywejBeziera[0].X - X;
                int PrzyrostY = PunktyKontrolneKrzywejBeziera[0].Y - Y;
                for(int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                {
                    PunktyKontrolneKrzywejBeziera[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X - PrzyrostX, PunktyKontrolneKrzywejBeziera[i].Y - PrzyrostY);
                }
            }
        }
    }
}

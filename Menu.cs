using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPrezentacja_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy formularz już istnieje
            foreach(Form FormX in Application.OpenForms)
                if(FormX.Name == "PrezentacjaLosowaZeSlajderem")
                {
                    //ukrycie bieżącego
                    Hide();
                    //odsłonięcie znalezionego
                    FormX.Show();
                    return;
                }
            //utworzenie egzemplarza formularza do którego chcemy przejść
            PrezentacjaLosowaZeSlajderem FormFigur = new PrezentacjaLosowaZeSlajderem();           
            //ukrycie bieżącego formularza
            this.Hide();
            //odsłonięcie formularza FormFigur
            FormFigur.Show();            
        }

        private void btnKreslenie_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy formularz już istnieje
            foreach (Form FormX in Application.OpenForms)
                if (FormX.Name == "KreslenieFigur_Linii")
                {
                    //ukrycie bieżącego
                    Hide();
                    //odsłonięcie znalezionego
                    FormX.Show();
                    return;
                }
            //utworzenie egzemplarza formularza do którego chcemy przejść
            KreslenieFigur_Linii FormFigur = new KreslenieFigur_Linii();
            //ukrycie bieżącego formularza
            this.Hide();
            //odsłonięcie formularza FormFigur
            FormFigur.Show();
        }
    }
}

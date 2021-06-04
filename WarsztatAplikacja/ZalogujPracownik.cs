using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarsztatAplikacja
{
    public partial class ZalogujPracownik : Form
    {
        Thread th;
        public ZalogujPracownik()
        {
            InitializeComponent();
        }

        private void powrot_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenStart);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenStart()
        {
            Application.Run(new Start());
        }

            linqtosqlDataContext db = new linqtosqlDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            var login = (from s in db.UzytkownicyAplikacji where s.Login == login_input.Text select s).First();
            if(login.Password==haslo_input.Text)
            {
                this.Close();
                th = new Thread(OpenPanelPracownika);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Login lub Hasło są nieprawidłowe!");
            }
        }

        private void OpenPanelPracownika()
        {
            Application.Run(new PanelPracownik());

        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}

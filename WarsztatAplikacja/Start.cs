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
    public partial class Start : Form
    {
        Thread th;

        public Start()
        {
            InitializeComponent();
        }

        private void Klient_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenPanelKlient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenPanelKlient()
        {
            Application.Run(new PanelKlient());
        }

        private void Pracownik_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenZalogujPracownik);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenZalogujPracownik()
        {
            Application.Run(new ZalogujPracownik());
        }
    }
}

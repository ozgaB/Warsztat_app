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
    public partial class PanelPracownik : Form
    {
        Thread th;
        public PanelPracownik()
        {
            InitializeComponent();
        }
        private void PanelPracownik_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNaprawyManager);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNaprawyManager()
        {
            Application.Run(new NaprawyManager());

        }

        private void usuńNaprawęToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void widoktabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        linqtosqlDataContext db = new linqtosqlDataContext();
        void LoadData()
        {
            wybierztabele.SelectedItem = "Dostawcy";
            string item = wybierztabele.SelectedItem.ToString();
            if(item == "Dostawcy")
            {
                var widok = db.select_dostawcy();
                widoktabel.DataSource = widok;
            }
        }

        private void PanelPracownik_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = wybierztabele.SelectedItem.ToString();
            if (item == "Naprawy")
            {
                var widok = db.naprawy_raport_wybór();
                widoktabel.DataSource = widok;
            }
            if (item == "Części")
            {
                var widok = db.select_czesci2();
                widoktabel.DataSource = widok;
            }
            if (item == "Dostawcy")
            {
                var widok = db.select_dostawcy();
                widoktabel.DataSource = widok;
            }
            if (item == "Samochody")
            {
                var widok = db.select_samochody1();
                widoktabel.DataSource = widok;
            }
        }

        private void samochodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenSamochodyManager);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenSamochodyManager()
        {
            Application.Run(new SamochodyManager());

        }

        private void częściToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenCzesciManager);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenCzesciManager()
        {
            Application.Run(new CzesciManager());

        }

        private void dostawcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenDostawcyManager);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenDostawcyManager()
        {
            Application.Run(new DostawcyManager());

        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

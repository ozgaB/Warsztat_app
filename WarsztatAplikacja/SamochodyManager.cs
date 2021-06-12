using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WarsztatAplikacja
{
    public partial class SamochodyManager : Form
    {
        Thread th;
        linqtosqlDataContext db = new linqtosqlDataContext();

        public SamochodyManager()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenStart);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenStart()
        {
            Application.Run(new PanelPracownik());

        }
        private void reload()
        {
            var widok = db.select_samochody();
            dataGridView1.DataSource = widok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PodgladKlienci p = new PodgladKlienci();
            p.Show();
        }
    }
}

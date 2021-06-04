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
    public partial class KlientRezultat : Form
    {
        Thread th;
        public int id_klient;
        public KlientRezultat()
        {
            InitializeComponent();
        }

        linqtosqlDataContext db = new linqtosqlDataContext();
        void zaladujwidok()
        {
            var widok = db.widok_wstawianie_rezultat2(id_klient);
            dataGridView1.DataSource = widok;
        }

        private void KlientRezultat_Load(object sender, EventArgs e)
        {
            zaladujwidok();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twoje zgłoszenie zostało przyjęte do realizacji");
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

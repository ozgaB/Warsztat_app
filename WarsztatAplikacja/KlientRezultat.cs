using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarsztatAplikacja
{
    public partial class KlientRezultat : Form
    {
        public int id_klient;
        public KlientRezultat()
        {
            InitializeComponent();
        }

        linqtosqlDataContext db = new linqtosqlDataContext();
        void zaladujwidok()
        {
            MessageBox.Show(id_klient.ToString());
            var widok = db.widok_wstawianie_rezultat1(id_klient);
            dataGridView1.DataSource = widok;
        }

        private void KlientRezultat_Load(object sender, EventArgs e)
        {
            zaladujwidok();
        }
    }
}

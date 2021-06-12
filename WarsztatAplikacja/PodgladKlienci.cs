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
    public partial class PodgladKlienci : Form
    {
        public PodgladKlienci()
        {
            InitializeComponent();
        }
        linqtosqlDataContext db = new linqtosqlDataContext();

        private void PodgladKlienci_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            var widok = db.select_klienci();
            dataGridView1.DataSource = widok;
        }
    }
}

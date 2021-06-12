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
    public partial class PodgladDostawcy : Form
    {
        public PodgladDostawcy()
        {
            InitializeComponent();
        }
        linqtosqlDataContext db = new linqtosqlDataContext();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reload();
        }

        private void PodgladDostawcy_Load(object sender, EventArgs e)
        {

        }
        private void reload()
        {
            var widok = db.select_dostawcy();
            dataGridView1.DataSource = widok;
        }
    }
}

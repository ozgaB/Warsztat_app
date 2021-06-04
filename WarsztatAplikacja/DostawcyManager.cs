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
    

    public partial class DostawcyManager : Form
    {
        Thread th;
        public DostawcyManager()
        {
            InitializeComponent();
        }
        linqtosqlDataContext db = new linqtosqlDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            //wstaw
            var wstawianie = db.dostawcy_wstawianie1(textBox2.Text, textBox3.Text);
            MessageBox.Show("Dodałeś nowy rekord");
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //usun
            var usuwanie = db.dostawcy_usuwanie1(int.Parse(textBox1.Text));
            MessageBox.Show("Usunęłeś rekord o ID: "+textBox1.Text);
            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aktualizuj = db.dostawcy_aktualizacja(int.Parse(textBox1.Text),textBox2.Text,textBox3.Text);
            MessageBox.Show("Zaktualizowałeś rekord o ID: " + textBox1.Text);
            reload();
        }

        private void DostawcyManager_Load(object sender, EventArgs e)
        {
            var widok = db.select_dostawcy();
            dataGridView1.DataSource = widok;
        }
        private void reload()
        {
            var widok = db.select_dostawcy();
            dataGridView1.DataSource = widok;
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}

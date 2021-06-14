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

        private void SamochodyManager_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            var wstawianie = db.samochody_wstawianie1(textBox2.Text, textBox3.Text, count, textBox5.Text);
            MessageBox.Show("Dodałeś nowy rekord");
            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(textBox1.Text);
            var wstawianie = db.samochody_usuwanie(count);
            MessageBox.Show("Usunąłeś nowy rekord");
            reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaktualizowałeś nowy rekord");
            reload();
        }
    }
}

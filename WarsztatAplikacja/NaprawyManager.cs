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
    public partial class NaprawyManager : Form
    {
        Thread th;
        linqtosqlDataContext db = new linqtosqlDataContext();
        public NaprawyManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PodgladKlienci p = new PodgladKlienci();
            p.Show();
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

        private void NaprawyManager_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            var widok = db.naprawy_raport_wybór();
            dataGridView1.DataSource = widok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //wstaw
            int count = Convert.ToInt32(numericUpDown1.Value);
            var wstawianie = db.naprawy_raport_wstawianie1(textBox2.Text, richTextBox1.Text,count);
            MessageBox.Show("Dodałeś nowy rekord");
            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //usun
            int count = Convert.ToInt32(textBox1.Text);

            var wstawianie = db.naprawy_raport_usuwanie(count);
            MessageBox.Show("Usunąłeś nowy rekord");
            reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idklient = Convert.ToInt32(numericUpDown1.Value);
            int id = Convert.ToInt32(textBox1.Text);
            var wstawianie = db.naprawy_raport_aktualizacja1(id,textBox2.Text, richTextBox1.Text, idklient);
            MessageBox.Show("Zaktualizowałeś nowy rekord");
            reload();
            //aktualizuj
        }
    }
}

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
    public partial class CzesciManager : Form
    {
        Thread th;
        linqtosqlDataContext db = new linqtosqlDataContext();
        public CzesciManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PodgladDostawcy p = new PodgladDostawcy();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //wstaw
            int count = Convert.ToInt32(numericUpDown1.Value);
            var wstawianie = db.czesci_wstawianie(textBox2.Text, textBox3.Text, count, textBox5.Text);
            MessageBox.Show("Dodałeś nowy rekord");
            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //usun
            int count = Convert.ToInt32(textBox1.Text);
            var wstawianie = db.czesci_usuwanie(count);
            MessageBox.Show("Usunąłeś rekord");
            reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //aktualizuj
            MessageBox.Show("Zaktualizowałeś rekord");
            reload();
        }
        private void reload()
        {
            var widok = db.select_czesci3();
            dataGridView1.DataSource = widok;
        }

        private void CzesciManager_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}

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
    public partial class PanelKlient : Form
    {
        Thread th;

        public PanelKlient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //     if(imie.Length && Nazwisko.Length == 0)
            {

            }
            using(KlientDaneKontaktowe s = new KlientDaneKontaktowe())
            {


                s.imie=textBox1.Text;
                s.Nazwisko=textBox2.Text;
                s.Firma=textBox3.Text;
                s.Nip=textBox4.Text;
                s.opis=richTextBox1.Text;
                s.data=monthCalendar1.Text;
                s.ShowDialog();
            }
            
            
        }

    }
}

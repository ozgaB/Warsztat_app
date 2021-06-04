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

    public partial class KlientDaneKontaktowe : Form
    {
        public string imie;
        public string Nazwisko;
        public string Firma;
        public string Nip;
        public string opis;
        public string data;
        public KlientDaneKontaktowe()
        {
            InitializeComponent();
        }
        linqtosqlDataContext db = new linqtosqlDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            // IF walidacja 
            string ulica = textBox1.Text;
            string nr = textBox2.Text;
            string miasto = textBox3.Text;
            string kod = textBox4.Text;
            string tel = textBox5.Text;
            string email = textBox6.Text;



            var klient = db.klienci_wstawianie(imie, Nazwisko, null, Firma, Nip);
            var wyszukaj = (from s in db.klienci where s.Imie == imie select s.id_klient).First();
            var kontakt = db.klienci_kontakt_wstawianie3(miasto, kod, ulica, nr, tel, email,wyszukaj);
            var raport = db.naprawy_raport_wstawianie1(null, opis,wyszukaj);
            using (KlientRezultat s = new KlientRezultat())
            {
                 s.id_klient = wyszukaj;
                s.ShowDialog();
            }
        }

        private void KlientDaneKontaktowe_Load(object sender, EventArgs e)
        {
        }
    }
}

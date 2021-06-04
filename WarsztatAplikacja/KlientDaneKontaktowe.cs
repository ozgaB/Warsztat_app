using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public bool IsCorrectMobileNumber(String tel)
        {
            Regex mobilePattern = new Regex(@"(\d{3})(\d{3})(\d{3})"); return mobilePattern.IsMatch(tel);
        }
        public bool IsCorrectkodpocztowy(String kod)
        {
            Regex mobilePattern = new Regex(@"(\d{2})-(\d{3})"); return mobilePattern.IsMatch(kod);
        }
        public bool IsCorrectemail(String email)
        {
            Regex mobilePattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); return mobilePattern.IsMatch(email);
        }
        linqtosqlDataContext db = new linqtosqlDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            int validation = 0;
            // IF walidacja 
            string ulica = textBox1.Text;
            string nr = textBox2.Text;
            string miasto = textBox3.Text;
            string kod = textBox4.Text;
            string tel = textBox5.Text;
            string email = textBox6.Text;
            if(((string.IsNullOrEmpty(imie))&&(string.IsNullOrEmpty(Nazwisko))) || ((string.IsNullOrEmpty(Firma))&&(string.IsNullOrEmpty(Nip))))
            {
                MessageBox.Show("Dane osobowe prywatne lub Dane firmy nie mogą być puste");
            }
            else
            {
                validation += 1;
            }
            if(string.IsNullOrEmpty(opis))
            {
                MessageBox.Show("Opis zgłoszenia naprawy nie może być pusty");
            }
            else
            {
                validation += 1;
            }
            if(IsCorrectMobileNumber(tel))
            {
                validation += 1;
            }
            else
            {
                MessageBox.Show("Nieprawidłowy numer telefonu");

            }
            if(IsCorrectkodpocztowy(kod))
            {
             validation += 1;
            }
            else
            {
                MessageBox.Show("Nieprawidłowy kod pocztowy");
            }
            if (IsCorrectemail(email))
            {
                validation += 1;

            }
            else
            {
                MessageBox.Show("Nieprawidłowy email");
            }




            if (validation == 5)
            {
                var klient = db.klienci_wstawianie(imie, Nazwisko, null, Firma, Nip);
                var wyszukaj = (from s in db.klienci where s.Imie == imie select s.id_klient).First();
                var kontakt = db.klienci_kontakt_wstawianie3(miasto, kod, ulica, nr, tel, email, wyszukaj);
                var raport = db.naprawy_raport_wstawianie1(null, opis, wyszukaj);
                using (KlientRezultat s = new KlientRezultat())
                {
                    s.id_klient = wyszukaj;
                    s.ShowDialog();
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Wypełnij błędne dane ponownie");
            }


        }

        private void KlientDaneKontaktowe_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelKlient s = new PanelKlient();
            s.ShowDialog();
        }
    }
}

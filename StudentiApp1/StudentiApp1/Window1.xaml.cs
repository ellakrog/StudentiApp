using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace StudentiApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Student st = new Student();
        public Student ST
        {
            get
            {
                st.Ime = textBoxIme.Text;
                st.Prezime = textBoxPrezime.Text;
                st.DatumRodjenja = textBoxRodjenje.Text;
                st.Generacija = int.Parse(textBoxGeneracija.Text);
                st.Smer = textBoxSmer.Text;
                st.Semestar = int.Parse(textBoxSemestar.Text);
                st.UlicaStanovanja = textBoxUlica.Text;
                st.BrojStanovanja = int.Parse(textBoxBrUlice.Text);
                st.MestoStanovanja = textBoxMesto.Text;
                st.Telefon = int.Parse(textBoxTelefon.Text);
                st.StudentId = int.Parse(textBoxID.Text);
                return st;
            }
            set
            {
                st = value;
                textBoxIme.Text = st.Ime;
                textBoxPrezime.Text = st.Prezime;
                textBoxRodjenje.Text = st.DatumRodjenja;
                textBoxGeneracija.Text = st.Generacija.ToString();
                textBoxSmer.Text = st.Smer;
                textBoxSemestar.Text = st.Semestar.ToString();
                textBoxUlica.Text = st.UlicaStanovanja;
                textBoxBrUlice.Text = st.BrojStanovanja.ToString();
                textBoxMesto.Text = st.MestoStanovanja;
                textBoxTelefon.Text = st.Telefon.ToString();
                textBoxID.Text = st.StudentId.ToString();
            }
        }

        public Window1()
        {
            InitializeComponent();
        }

        private void buttonSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxIme.Text))
            {
                MessageBox.Show("Morate uneti ime studenta", "Poruka");
                textBoxIme.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Morate uneti prezime studenta", "Poruka");
                textBoxPrezime.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxRodjenje.Text))
            {
                MessageBox.Show("Morate uneti datum rodjenja");
                textBoxRodjenje.Focus();
                return;
            }

            int gen;
            if (!int.TryParse(textBoxGeneracija.Text, out gen))
            {
                MessageBox.Show("Morate uneti tacnu generaciju studenata", "Poruka");
                textBoxGeneracija.Clear();
                textBoxGeneracija.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSmer.Text))
            {
                MessageBox.Show("Morate uneti smer studenta", "Poruka");
                textBoxSmer.Focus();
                return;
            }
            int sem;
            if (!int.TryParse(textBoxSemestar.Text, out sem))
            {
                MessageBox.Show("Morate uneti tacan semestar studenata", "Poruka");
                textBoxSemestar.Clear();
                textBoxSemestar.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxUlica.Text))
            {
                MessageBox.Show("Morate uneti ulicu studenta", "Poruka");
                textBoxUlica.Focus();
                return;
            }
            int br;
            if (!int.TryParse(textBoxBrUlice.Text, out br))
            {
                MessageBox.Show("Morate uneti tacan broj ulice studenata", "Poruka");
                textBoxBrUlice.Clear();
                textBoxBrUlice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMesto.Text))
            {
                MessageBox.Show("Morate uneti mesto stanovanja studenta", "Poruka");
                textBoxMesto.Focus();
                return;
            }
            double tel;
            if (!double.TryParse(textBoxTelefon.Text, out tel))
            {
                MessageBox.Show("Morate uneti tacan telefon studenta", "Poruka");
                textBoxTelefon.Clear();
                textBoxTelefon.Focus();
                return;
            }

             DialogResult = true;
           
        }

        private void buttonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}

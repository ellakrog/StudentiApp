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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;


namespace StudentiApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> listaStudenata = new List<Student>();

        private int sId = 0;

        private void sacuvaj()
        {
            
            foreach (Student st in listaStudenata)
            {
                string str = st.ToString();
                string[] str1 = new string[] {str };
                File.AppendAllLines("mojFajl.dat", str1);
            }

        }
       
        private void prikazi()
        {
            listBox1.Items.Clear();

            foreach (Student st in listaStudenata)
            {
                listBox1.Items.Add(st);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("mojFajl.dat"))
            {
                return;
            }
            else
            {
                FileInfo f = new FileInfo("mojFajl.dat");
                if (f.Length > 0)
                {
                    string[] lines = File.ReadAllLines("mojFajl.dat");
                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("Nematrenutno sacuvanih podataka!");
                }
            }
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            sId++;
            Window1 unos = new Window1();
            unos.textBoxID.Text = sId.ToString();
            unos.Title = "Unos podataka";
            if (unos.ShowDialog() == true)
            {
                Student st1 = unos.ST;
                listaStudenata.Add(st1);
                prikazi();
                sacuvaj();
            }
            else
            {
                sId--;
            }
        }

        private void buttonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index > -1)
            {
                Student st1 = listaStudenata[index];
                Window1 w1 = new Window1();
                w1.Title = "Izmena podataka";
                w1.ST = st1;
                if (w1.ShowDialog() == true)
                {
                    listaStudenata[index] = w1.ST;
                    prikazi();
                    sacuvaj();
                    listBox1.SelectedIndex = index;
                }
                
            }
            else
            {
                MessageBox.Show("Odaberite studenta cije podatke menjate!");
            }
        }

        private void buttonObrisi_Click(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index > -1)
            {
                Window2 w2 = new Window2();
                w2.Title = "Delete";
                w2.label1.Content = "Da li zelite da obrisete podatke o studentu?";

                if (w2.ShowDialog() == true)
                {
                    listaStudenata.RemoveAt(index);
                    prikazi();                  

                }              
                
            }
            else
            {
                MessageBox.Show("Odaberite studenta cije podatke brisete!");
            }
        }
       
    }
}

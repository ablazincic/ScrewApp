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

namespace ScrewApp
{
    /// <summary>
    /// Interaction logic for IzmjenaWindow.xaml
    /// </summary>
    public partial class IzmjenaWindow : Window
    {
        public IzmjenaWindow()
        {
            InitializeComponent();
            this.Closing += IzmjenaWindow_Closing;
            listBoxScrew.Foreground = (Brush)new BrushConverter().ConvertFrom("#fff");
            Refresh();
            
        }
        static ScrewAppDBEntities context = new ScrewAppDBEntities();

        private void IzmjenaWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; // Sprečava zatvaranje prozora
            this.Hide(); // Sakriva prozor umesto da ga zatvori

            // Prikaz glavnog prozora
            var window = new MainWindow();
            window.Show();

        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (txtNaziv.Text != "")
            {
                Screw s = new Screw();

                s.sName = txtNaziv.Text;

               
                    context.Screw.Add(s);
                    context.SaveChanges();
                
               
                Refresh();

            }
            txtNaziv.Clear();
        }

        public void Refresh()
        {
            listBoxScrew.Items.Clear();

            foreach (var s in context.Screw.ToList() )
            {
                listBoxScrew.Items.Add(s);
            }

        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxScrew.SelectedIndex!=-1)
            {
                Screw DScrew = listBoxScrew.SelectedItem as Screw;

                foreach (var s in context.Screw.ToList())
                {
                    if (s.ID == DScrew.ID)
                    {
                        context.Screw.Remove(s);
                        context.SaveChanges();
                        Refresh();
                        break;
                    }
                }
            }
           
        }
    }
}

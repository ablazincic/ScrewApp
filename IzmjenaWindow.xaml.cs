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
        }

        private void IzmjenaWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; // Sprečava zatvaranje prozora
            this.Hide(); // Sakriva prozor umesto da ga zatvori

            // Prikaz glavnog prozora
            var window = new MainWindow();
            window.Show();

        }
    }
}

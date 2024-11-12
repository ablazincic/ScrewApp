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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ScrewApp
{
    /// <summary>
    /// Interaction logic for IspisWindow.xaml
    /// </summary>
    public partial class IspisWindow : Window
    {
        public IspisWindow()
        {
            InitializeComponent();
            this.Closing += IspisWindow_Closing; 
        }

        private void IspisWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; // Sprečava zatvaranje prozora
            this.Hide(); // Sakriva prozor umesto da ga zatvori

            // Prikaz glavnog prozora
            var window = new MainWindow();
            window.Show();

        }

    }
}

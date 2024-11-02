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

namespace ScrewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Application.Current.Shutdown();
        }
    


     

        private void lblPretraga_MouseEnter(object sender, MouseEventArgs e)
        {
            lblPretraga.Foreground = (Brush)new BrushConverter().ConvertFrom("#B0C4DE");
            lblPretraga.FontWeight = FontWeights.Bold;
        }

        private void lblPretraga_MouseLeave(object sender, MouseEventArgs e)
        {
            lblPretraga.Foreground = (Brush)new BrushConverter().ConvertFrom("#A4D3E2");
            lblPretraga.FontWeight = FontWeights.Regular;
        }

        private void lblPretraga_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var pretraga = new PretragaWindow();

            pretraga.Show();
            this.Hide();
        }

        private void lblIzmjena_MouseEnter(object sender, MouseEventArgs e)
        {
            lblIzmjena.Foreground = (Brush)new BrushConverter().ConvertFrom("#B0C4DE");
            lblIzmjena.FontWeight = FontWeights.Bold;
        }

        private void lblIzmjena_MouseLeave(object sender, MouseEventArgs e)
        {
            lblIzmjena.Foreground = (Brush)new BrushConverter().ConvertFrom("#A4D3E2");
            lblIzmjena.FontWeight = FontWeights.Regular;
        }

        private void lblIzmjena_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var izmjena = new IzmjenaWindow();

            izmjena.Show();
            this.Hide();
        }

        private void LblIspis_MouseEnter_1(object sender, MouseEventArgs e)
        {
            LblIspis.Foreground = (Brush)new BrushConverter().ConvertFrom("#B0C4DE");
            LblIspis.FontWeight = FontWeights.Bold;
        }

        private void LblIspis_MouseLeave_1(object sender, MouseEventArgs e)
        {
            LblIspis.Foreground = (Brush)new BrushConverter().ConvertFrom("#A4D3E2");
            LblIspis.FontWeight = FontWeights.Regular;
        }

        private void LblIspis_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            var ispis = new IspisWindow();

            ispis.Show();
            this.Hide();
        }
    }
}

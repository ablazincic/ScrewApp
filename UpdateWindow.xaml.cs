using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {

        private IzmjenaWindow izmjena;
        public UpdateWindow(Screw s, IzmjenaWindow i)
        {
            InitializeComponent();
            txtID.Text = s.ID.ToString();
            txtNaziv.Text = s.sName;
            izmjena = i;

        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            foreach (var screw in IzmjenaWindow.context.Screw.ToList() )
            {
                if (screw.ID == int.Parse(txtID.Text) && txtNaziv.Text != screw.sName)
                {
                    screw.sName = txtNaziv.Text;
                    IzmjenaWindow.context.SaveChanges();
                    txtID.Clear();
                    txtNaziv.Clear();
                    izmjena.Refresh();
                    this.Close();                  
                    break;


                }

            }
        }
    }
}

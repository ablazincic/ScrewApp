using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
       public static ScrewAppDBEntities context = new ScrewAppDBEntities();

        private void IzmjenaWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; 
            this.Hide(); 

            // Prikaz glavnog prozora
            var window = new MainWindow();
            window.Show();

        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (txtNaziv.Text != "" && !txtNaziv.Text.Contains("/"))
            {
                Screw s = new Screw();

                s.sName = txtNaziv.Text;

               
                    context.Screw.Add(s);
                    context.SaveChanges();
                
               
                Refresh();
                txtNaziv.Clear();
            }
            else
            {
                txtNaziv.Clear();
                MessageBox.Show("Naziv vijka ne smije sadržavati '/' u sebi!");
            }
            
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

       

        private void listBoxScrew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
                imgIzmjeni.Source = null; 
                Screw s = listBoxScrew.SelectedItem as Screw;
            if (s != null)
            {
                foreach (var screw in context.Screw)
                {
                    if (screw==s)
                    {

                   
                    string projectDir = Directory.GetCurrentDirectory();
                    string imagePath = System.IO.Path.Combine(projectDir, "..\\..\\photos", screw.sName + ".png");


                    if (File.Exists(imagePath))
                    {
                        imgIzmjeni.Source = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
                        imagePath = null;
                    }

                    else
                    {
                        MessageBox.Show($"Image not found: {imagePath}");
                    }
                    break;

                    }
                }
            }


        }

        private void btnAzuriraj1_Click(object sender, RoutedEventArgs e)
        {
            
            Screw updateScrew = listBoxScrew.SelectedItem as Screw;
            UpdateWindow updateWin = new UpdateWindow(updateScrew, this);
            updateWin.Show();
         
            

         
          


        }

        private void btnSlika_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Odaberi fotografiju.";
            dialog.Filter = "Image files *.png| *.png";
            dialog.ShowDialog();
            string sourceFilePath = dialog.FileName;

            string projectDir = Directory.GetCurrentDirectory(); 
            string targetDir = System.IO.Path.Combine(projectDir, "..\\..\\photos");
            string targetFilePath = System.IO.Path.Combine(targetDir, System.IO.Path.GetFileName(sourceFilePath));

           
           
            
            File.Copy(sourceFilePath, targetFilePath, overwrite: true);
        }
    }
}

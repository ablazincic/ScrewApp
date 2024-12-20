﻿using System;
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
    /// Interaction logic for PretragaWindow.xaml
    /// </summary>
    public partial class PretragaWindow : Window
    {
        public PretragaWindow()
        {
            InitializeComponent();
            this.Closing += PretragaWindow_Closing;
        }

        private void PretragaWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; // Sprečava zatvaranje prozora
            this.Hide(); // Sakriva prozor umesto da ga zatvori

            // Prikaz glavnog prozora
            var window = new MainWindow();
            window.Show();

           

        }

        private void txtPretraga_TextChanged(object sender, TextChangedEventArgs e)
        {
            var pretraga = txtPretraga.Text.ToLower();
            lbPretraga.Items.Clear();
            //var filtriraniVijci = IzmjenaWindow.context.Screw.Where(s => s.sName.Contains(pretraga)).ToList();
            foreach (var s in IzmjenaWindow.context.Screw.ToList())
            {
                if (s.sName.Contains(pretraga))
                {
                    
                    lbPretraga.Items.Add(s);
                  

                }
            }
           

           
        }
    }
}

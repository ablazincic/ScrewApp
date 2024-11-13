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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Win32;

using iTextParagraph = iTextSharp.text.Paragraph;
using iTextRectangle = iTextSharp.text.Rectangle;


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
            MessageBoxResult rezultat = MessageBox.Show("Želite li ispis sa slikama, ili bez slika?", "Ispis u PDF", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF  (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Vijci";
            saveFileDialog.Title = "Spremi kao PDF";

            if (rezultat == MessageBoxResult.Yes)
            {
                
            }
            else if(rezultat == MessageBoxResult.No)
            {
                saveFileDialog.ShowDialog();
                string putanja = saveFileDialog.FileName;

                Document pdfDocument = new Document(PageSize.A4);
    
                PdfWriter.GetInstance(pdfDocument, new FileStream(putanja, FileMode.Create));
                pdfDocument.Open();
          

                Font TitleFont = new Font();
                TitleFont.IsBold();
                TitleFont.Size = 32;

                Font dateFont = new Font();
                dateFont.Size = 10;

                Font headerFont = new Font();
                headerFont.IsBold();

                //iTextParagraph title = new iTextParagraph("Vijci",TitleFont);
                //title.Alignment = Element.ALIGN_CENTER;
                //title.SpacingAfter = 20;

                //iTextParagraph date = new iTextParagraph("Kreirano "+DateTime.Now.ToString("dd.MM.yyyy HH:mm."));
                //date.Alignment = Element.ALIGN_RIGHT;


                //pdfDocument.Add(title);

                string formattedDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                Chunk Title = new Chunk("Popis Vijaka",TitleFont);
                Chunk Datum = new Chunk("kreirano ".PadLeft(45)+formattedDate,dateFont);

                Phrase elementi = new Phrase();

                elementi.Add(Title);
                elementi.Add(Datum);

                iTextParagraph naslovnica = new iTextParagraph(elementi);

                naslovnica.Alignment = Element.ALIGN_CENTER;
                naslovnica.SpacingAfter = 70;

                pdfDocument.Add(naslovnica);

                iTextParagraph header = new iTextParagraph("ID".PadRight(10) + "Naziv vijka",headerFont);
                header.SpacingAfter = 15;

                pdfDocument.Add(header);
              

                foreach (var s in IzmjenaWindow.context.Screw.ToList())
                {
                    pdfDocument.Add(new iTextParagraph(s.ID.ToString().PadRight(10)+s.sName));
                }
                //pdfDocument.Add(date);
                pdfDocument.CloseDocument();
                //MessageBox.Show("dokumenat je dovršen.");

            }

        }
    }
}

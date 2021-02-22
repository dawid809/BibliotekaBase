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

namespace BibliotekaBase.Views
{
    /// <summary>
    /// Interaction logic for KsiazkiPage.xaml
    /// </summary>
    public partial class KsiazkiPage : Page
    {
        public KsiazkiPage()
        {
            InitializeComponent();

            BibliotekaEntities db = new BibliotekaEntities();
            this.ksiazkisDataGrid.ItemsSource = db.Ksiazkis.ToList();
        }

        private void Button_Add_Ksiazki(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();

            Ksiazki ksiazki = new Ksiazki()
            {
                Autor_ID = int.Parse(autor_IDTextBox.Text.Trim()),
                Ilosc_stron = int.Parse(ilosc_stronTextBox.Text.Trim()),
                Nazwa = nazwaTextBox.Text.Trim(),
                TypKsiazki_ID = int.Parse(typKsiazki_IDTextBox.Text.Trim())
            };
            db.Ksiazkis.Add(ksiazki);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano");
            Refresh();
        }

        private void Button_Delete_Ksiazki(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Update_Ksiazki(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh()
        {
            BibliotekaEntities db = new BibliotekaEntities();
            this.ksiazkisDataGrid.ItemsSource = db.Ksiazkis.ToList();
        }
    }
}

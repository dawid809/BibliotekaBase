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

            try
            {
                Ksiazki ksiazki = new Ksiazki()
                {
                    Autor_ID = int.Parse(autor_IDTextBox.Text.Trim()),
                    Ilosc_stron = int.Parse(ilosc_stronTextBox.Text.Trim()),
                    Nazwa = nazwaTextBox.Text.Trim(),
                    TypKsiazki_ID = int.Parse(typKsiazki_IDTextBox.Text.Trim())
                };
                db.Ksiazkis.Add(ksiazki);
                db.SaveChanges();
                MessageBox.Show("Pomyślnie dodano!", "Info");
                Refresh();
            }

            catch (Exception)
            {
                MessageBox.Show("Podaj wszystkie wartośći w polach tekstowych!\n\nSprawdź typ książki o takim ID istnieje.", "Info", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Delete_Ksiazki(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();

            try
            {
                int id = (ksiazkisDataGrid.SelectedItem as Ksiazki).Ksiazka_ID;
                var delteKsiazka = db.Ksiazkis.Where(k => k.Ksiazka_ID == id).SingleOrDefault();
                var delteWypozyczenia = db.Wypozyczenias.Where(w => w.Ksiazka_ID == id);
                db.Wypozyczenias.RemoveRange(delteWypozyczenia);
                db.SaveChanges();
                db.Ksiazkis.Remove(delteKsiazka);
                db.SaveChanges();
                ksiazkisDataGrid.ItemsSource = db.Ksiazkis.ToList();
                MessageBox.Show("Pomyślnie usunięto!", "Info");
            }

            catch (Exception)
            {
                MessageBox.Show("Zaznacz wiersz w tabeli, który chcesz usunąć", "Info", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Refresh()
        {
            BibliotekaEntities db = new BibliotekaEntities();
            this.ksiazkisDataGrid.ItemsSource = db.Ksiazkis.ToList();
        }
    }
}

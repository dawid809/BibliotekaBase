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
    /// Interaction logic for AutorzyPage.xaml
    /// </summary>
    public partial class AutorzyPage : Page
    {
        public AutorzyPage()
        {
            InitializeComponent();
            BibliotekaEntities db = new BibliotekaEntities();
            this.autorziesDataGrid.ItemsSource = db.Autorzies.ToList();
        }

        private void Button_Add_Autorzy(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();

            Autorzy autorzy = new Autorzy()
            {
               Imie = imieTextBox.Text.Trim(),
               Nazwisko = nazwiskoTextBox.Text.Trim()
            };
                db.Autorzies.Add(autorzy);
                db.SaveChanges();
                MessageBox.Show("Pomyślnie dodano!", "Info");
                Refresh();
        }

        private void Refresh()
        {
            BibliotekaEntities db = new BibliotekaEntities();
            this.autorziesDataGrid.ItemsSource = db.Autorzies.ToList();
        }

        private void Button_Delete_Autorzy(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();
            try
            {
                int id = (autorziesDataGrid.SelectedItem as Autorzy).Autor_ID;
                var deleteAutor = db.Autorzies.Where(a => a.Autor_ID == id).SingleOrDefault();
                var deleteKsiazka = db.Ksiazkis.Where(k => k.Autor_ID == id);
                db.Ksiazkis.RemoveRange(deleteKsiazka);
                db.SaveChanges();
                db.Autorzies.Remove(deleteAutor);
                db.SaveChanges();
                autorziesDataGrid.ItemsSource = db.Autorzies.ToList();
                MessageBox.Show("Pomyślnie usunięto!", "Info");
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz wiersz w tabeli, który chcesz usunąć", "Info", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

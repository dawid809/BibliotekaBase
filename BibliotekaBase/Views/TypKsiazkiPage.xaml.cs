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
    /// Interaction logic for TypKsiazkiPage.xaml
    /// </summary>
    public partial class TypKsiazkiPage : Page
    {
        public TypKsiazkiPage()
        {
            InitializeComponent();

            BibliotekaEntities db = new BibliotekaEntities();
            this.typKsiazkisDataGrid.ItemsSource = db.TypKsiazkis.ToList();
        }

        private void Button_Add_TypKsiazki(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();

            TypKsiazki typKsiazki = new TypKsiazki()
            {
               Nazwa = nazwaTextBox.Text.Trim()
            };
            db.TypKsiazkis.Add(typKsiazki);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano!", "Info");
            Refresh();
        }

        private void Refresh()
        {
            BibliotekaEntities db = new BibliotekaEntities();
            this.typKsiazkisDataGrid.ItemsSource = db.TypKsiazkis.ToList();
        }

        private void Button_Delete_TypKsiazki(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();
            try
            {
                int id = (typKsiazkisDataGrid.SelectedItem as TypKsiazki).TypKsiazki_ID;
                var deleteTyp = db.TypKsiazkis.Where(t => t.TypKsiazki_ID == id).SingleOrDefault();
                var deleteKsiazki = db.Ksiazkis.Where(k => k.TypKsiazki_ID == id);
                db.Ksiazkis.RemoveRange(deleteKsiazki);
                db.SaveChanges();
                db.TypKsiazkis.Remove(deleteTyp);
                db.SaveChanges();
                typKsiazkisDataGrid.ItemsSource = db.TypKsiazkis.ToList();
                MessageBox.Show("Pomyślnie usunięto!", "Info");
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz wiersz w tabeli, który chcesz usunąć", "Info", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

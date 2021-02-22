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
    /// Interaction logic for WypozyczeniaPage.xaml
    /// </summary>
    public partial class WypozyczeniaPage : Page
    {
        public WypozyczeniaPage()
        {
            InitializeComponent();

            BibliotekaEntities db = new BibliotekaEntities();
            this.wypozyczeniasDataGrid.ItemsSource = db.Wypozyczenias.ToList();
        }

        private void Button_Add_Wypozyczenia(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();

            Wypozyczenia wypozyczenia = new Wypozyczenia()
            {
                Student_ID = int.Parse(student_IDTextBox.Text.Trim()),
                Ksiazka_ID = int.Parse(ksiazka_IDTextBox.Text.Trim()),
                Data_Wypozyczenia = (DateTime)data_WypozyczeniaDatePicker.SelectedDate,
                Data_Oddania = (DateTime)data_OddaniaDatePicker.SelectedDate
            };
            db.Wypozyczenias.Add(wypozyczenia);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano!");
            Refresh();
        }

        private void Button_Update_Wypozyczenia(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh()
        {
            BibliotekaEntities db = new BibliotekaEntities();
            this.wypozyczeniasDataGrid.ItemsSource = db.Wypozyczenias.ToList();
        }
    }
}

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
    /// Interaction logic for StudenciPage.xaml
    /// </summary>
    public partial class StudenciPage : Page
    {
        public StudenciPage()
        {
            InitializeComponent();

            BibliotekaEntities db = new BibliotekaEntities();
            this.studencisDataGrid.ItemsSource = db.Studencis.ToList();
        }

        private void Button_Add_Studenci(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();

            Studenci studenci = new Studenci()
            {
                Imie = imieTextBox.Text.Trim(),
                Nazwisko = nazwiskoTextBox.Text.Trim(),
                DataUrodzenia = (DateTime)dataUrodzeniaDatePicker.SelectedDate
            };
            db.Studencis.Add(studenci);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano!");
            Refresh();
        }

        private void Button_Delete_Studenci(object sender, RoutedEventArgs e)
        {
            BibliotekaEntities db = new BibliotekaEntities();
            int id = (studencisDataGrid.SelectedItem as Studenci).Student_ID;
            var deleteStudent = db.Studencis.Where(s => s.Student_ID == id).SingleOrDefault();
            var deleteWypozyczenia = db.Wypozyczenias.Where(w => w.Student_ID == id);
            db.Wypozyczenias.RemoveRange(deleteWypozyczenia);
            db.SaveChanges();
            db.Studencis.Remove(deleteStudent);
            db.SaveChanges();
            studencisDataGrid.ItemsSource = db.Studencis.ToList();
            MessageBox.Show("Pomyślnie usunięto!");
        }

        private void Button_Update_Studenci(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh()
        {
            BibliotekaEntities db = new BibliotekaEntities();
            this.studencisDataGrid.ItemsSource = db.Studencis.ToList();
        }
    }
}

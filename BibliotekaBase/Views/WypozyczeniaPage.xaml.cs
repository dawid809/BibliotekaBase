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

        }

        private void Button_Delete_Wypozyczenia(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Update_Wypozyczenia(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
    }
}

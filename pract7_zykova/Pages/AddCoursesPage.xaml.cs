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

namespace pract7_zykova.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddCoursesPage.xaml
    /// </summary>
    public partial class AddCoursesPage : Page
    {
        public AddCoursesPage()
        {
            InitializeComponent();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }
    }
}

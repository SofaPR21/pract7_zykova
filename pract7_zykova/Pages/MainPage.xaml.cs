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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void go_form(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCoursesPage());
        }

        private void remove(object sender, RoutedEventArgs e)
        {

        }

        public void Edit(object sender, EventArgs e)
        {
        //    if (user == null)
        //    {
        //        MessageBox.Show("Выберите элемент из списка!");
        //        return;
        //    }
        //    NavigationService.Navigate(new ChangeUserPage(user));
        }

    }
}

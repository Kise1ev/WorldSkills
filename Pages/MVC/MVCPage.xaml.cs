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
using WorldSkills.Pages.MVC.Controller;
using WorldSkills.Pages.MVC.HelpController;

namespace WorldSkills.Pages.MVC
{
    /// <summary>
    /// Логика взаимодействия для MVCPage.xaml
    /// </summary>
    public partial class MVCPage : Page
    {
        public MVCPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBtn_Click(object sender, RoutedEventArgs e)
        {
            ControllerLogin controllerLogin = new ControllerLogin();
            ClientInfo.LoginClient = LoginTxt.Text;
            MessageBox.Show(controllerLogin.CheckLoginInOdb(LoginTxt.Text), "Проверка наличия пользователя", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

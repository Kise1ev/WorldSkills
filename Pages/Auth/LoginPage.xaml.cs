using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;
using WorldSkills.Pages.Admin;
using WorldSkills.Pages.Student;
using WorldSkills.Pages.Teacher;

namespace WorldSkills.Pages.Auth
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage() 
            => InitializeComponent();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(LoginTxt.Text))
                    throw new ArgumentException("Введите логин в поле ввода!");

                if (string.IsNullOrWhiteSpace(PasswordPxt.Password))
                    throw new ArgumentException("Введите пароль в поле ввода!");

                User user = AppConnect.ModelOdb.User
                    .FirstOrDefault(x => x.Login == LoginTxt.Text && x.Password == PasswordPxt.Password) 
                    ?? throw new NullReferenceException($"Пользователь {LoginTxt.Text} не найден!");

                AccountHelpClass.Id = user.ID;
                switch (user.RoleID)
                {
                    case 1:
                        MessageBox.Show($"Здравствуйте, преподаватель - {user.Name}!", "Успешная авторизация!", MessageBoxButton.OK, MessageBoxImage.Information); ;
                        AppFrame.FrameMain.Navigate(new TeacherPage());
                        break;
                    case 2:
                        MessageBox.Show($"Здравствуйте, студент - {user.Name}!", "Успешная авторизация!", MessageBoxButton.OK, MessageBoxImage.Information); ;
                        AppFrame.FrameMain.Navigate(new StudentPage());
                        break;
                    case 3:
                        MessageBox.Show($"Здравствуйте, администратор - {user.Name}!", "Успешная авторизация!", MessageBoxButton.OK, MessageBoxImage.Information); ;
                        AppFrame.FrameMain.Navigate(new AdminPage());
                        break;
                    default:
                        throw new Exception("Произошел сбой при поиске роли пользователя!");
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show($"Ошибка ввода данных!\n{exception.Message}", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show($"Ошибка авторизации!\n{exception.Message}", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Произошла неизвестная ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBtn_Click(object sender, RoutedEventArgs e) 
            => AppFrame.FrameMain.Navigate(new RegisterPage());
    }
}
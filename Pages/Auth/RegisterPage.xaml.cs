using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using WorldSkills.ApplicationData;
using System.Linq;
using System;

namespace WorldSkills.Pages.Auth
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage() 
            => InitializeComponent();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTxt.Text))
                    throw new ArgumentException("Введите имя в поле ввода!");

                if (string.IsNullOrWhiteSpace(LoginTxt.Text))
                    throw new ArgumentException("Введите логин в поле ввода!");

                if (string.IsNullOrWhiteSpace(PasswordPxt.Password))
                    throw new ArgumentException("Введите пароль в поле ввода!");

                int count = AppConnect.ModelOdb.User
                    .Count(x => x.Login == LoginTxt.Text);
                if (count > 0)
                    throw new Exception("Пользователь с таким логином уже существует!");
                User user = new User
                {
                    Login = LoginTxt.Text,
                    Password = PasswordPxt.Password,
                    RoleID = 2,
                    Name = NameTxt.Text,
                    DateIn = DateTime.Now
                };
                AppConnect.ModelOdb.User.Add(user);
                AppConnect.ModelOdb.SaveChanges();

                MessageBox.Show("Вы были успешно зарегистрированы!", "Успешная регистрация!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show($"Ошибка ввода данных!\n{exception.Message}", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
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
        private void LoginBtn_Click(object sender, RoutedEventArgs e) 
            => AppFrame.FrameMain.Navigate(new LoginPage());

        /// <summary>
        /// Обработчик события изменения пароля в поле PasswordPxt.
        /// Проверяет соответствие паролей, обновляет состояние текстового поля RePasswordPxt и активность кнопки RegisterBtn.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void PasswordPxt_PasswordChanged(object sender, RoutedEventArgs e) 
            => UpdateRePasswordTextBoxState();

        /// <summary>
        /// Обработчик события изменения пароля в поле RePasswordPxt.
        /// Проверяет соответствие паролей, обновляет состояние текстового поля RePasswordPxt и активность кнопки RegisterBtn.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void RePasswordPxt_PasswordChanged(object sender, RoutedEventArgs e) 
            => UpdateRePasswordTextBoxState();

        /// <summary>
        /// Обновляет состояние текстового поля RePasswordPxt и активность кнопки RegisterBtn в зависимости от паролей PasswordPxt и RePasswordPxt.
        /// </summary>
        private void UpdateRePasswordTextBoxState()
        {
            bool passwordEmpty = string.IsNullOrWhiteSpace(PasswordPxt.Password);
            bool passwordsMatch = !string.IsNullOrWhiteSpace(RePasswordPxt.Password) && RePasswordPxt.Password == PasswordPxt.Password;

            RePasswordPxt.BorderBrush = (passwordEmpty || !passwordsMatch) ? Brushes.Red : Brushes.Green;
            RePasswordPxt.Background = (passwordEmpty || !passwordsMatch) ? Brushes.LightCoral : Brushes.LightGreen;
            RegisterBtn.IsEnabled = !passwordEmpty && passwordsMatch;
        }
    }
}
using System;
using System.Windows;

namespace WorldSkills.Windows
{
    /// <summary>
    /// Логика взаимодействия для CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        private int TypeEvent;

        public CustomMessageBox(int eventId)
        {
            InitializeComponent();

            TypeEvent = eventId;
            EventSet();
        }

        public void EventSet()
        {
            try
            {
                switch (TypeEvent)
                {
                    case 1:
                        MessageTxt.Text = "Информация успешно добавлена!";
                        break;
                    default:
                        MessageTxt.Text = "Ошибка работы приложения!";
                        break;
                }
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
            => Close();
    }
}
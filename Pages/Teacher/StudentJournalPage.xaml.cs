using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для StudentJournalPage.xaml
    /// </summary>
    public partial class StudentJournalPage : Page
    {
        public StudentJournalPage(ApplicationData.Student student)
        {
            InitializeComponent();
            StudentNameTxt.Text = student.Name;
            EvaluationList.ItemsSource = AppConnect.ModelOdb.Journal.Where(x => x.StudentID == student.ID).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() != true)
                    throw new Exception("Пользователь прервал печать!");

                GoToBackBtn.Background = Brushes.Transparent;
                GoToBackBtn.BorderBrush = Brushes.Transparent;
                GoToBackBtn.Width = 400;
                GoToBackBtn.Foreground = Brushes.Black;
                GoToBackBtn.Content = "Страница с оценками студента";

                PrintBtn.Visibility = Visibility.Hidden;

                print.PrintVisual(MainGrid, "");
                AppFrame.FrameMain.GoBack();
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
        private void GoToBackBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.GoBack();
    }
}

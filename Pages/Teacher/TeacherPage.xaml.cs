using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;
using WorldSkills.Pages.MVC;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public TeacherPage()
            => InitializeComponent();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new AddStudentPage());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEvaluationBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new AddEvaluationPage());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentListBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new StudentListPage());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEvaluationBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new EditEvaluationPage());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new DeleteStudentPage());

        private void MVCBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new MVCPage());
    }
}
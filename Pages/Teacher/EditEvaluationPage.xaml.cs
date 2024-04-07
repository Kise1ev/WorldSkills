using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для EditEvaluationPage.xaml
    /// </summary>
    public partial class EditEvaluationPage : Page
    {
        public EditEvaluationPage()
        {
            InitializeComponent();

            GroupNameCmb.SelectedValuePath = "ID";
            GroupNameCmb.DisplayMemberPath = "Name";
            GroupNameCmb.ItemsSource = AppConnect.ModelOdb.GroupName.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupNameCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectGroup = Convert.ToInt32(GroupNameCmb.SelectedValue);
            StudentList.ItemsSource = AppConnect.ModelOdb.Student.Where(x => x.GroupID == selectGroup).ToList();
            StudentList.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEvaluationBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new EditStudentGradePage((sender as Button).DataContext as ApplicationData.Student));
    }
}
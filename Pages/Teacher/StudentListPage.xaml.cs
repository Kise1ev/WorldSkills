using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для StudentListPage.xaml
    /// </summary>
    public partial class StudentListPage : Page
    {
        public StudentListPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = AppConnect.ModelOdb.GroupName.ToList();

            StudentList.ItemsSource = AppConnect.ModelOdb.Student.ToList();

            DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer.Tick += UpdateData;
            timer.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateData(object sender, object e)
            => StudentList.ItemsSource = AppConnect.ModelOdb.Student.ToList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentList.ItemsSource = AppConnect.ModelOdb.Student.Where(x => x.GroupID == selectGroup).ToList();
            StudentList.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectStudentBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.Navigate(new StudentJournalPage((sender as Button).DataContext as ApplicationData.Student));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToBackBtn_Click(object sender, RoutedEventArgs e)
            => AppFrame.FrameMain.GoBack();
    }
}

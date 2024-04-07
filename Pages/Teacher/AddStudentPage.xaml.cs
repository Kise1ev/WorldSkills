using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;
using WorldSkills.Windows;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();

            SpecialCmb.SelectedValuePath = "ID";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = AppConnect.ModelOdb.Special.ToList();

            YearAddCmb.SelectedValuePath = "ID";
            YearAddCmb.DisplayMemberPath = "Year";
            YearAddCmb.ItemsSource = AppConnect.ModelOdb.YearAdd.ToList();

            GroupNameCmb.SelectedValuePath = "ID";
            GroupNameCmb.DisplayMemberPath = "Name";
            GroupNameCmb.ItemsSource = AppConnect.ModelOdb.GroupName.ToList();

            FormTimeCmb.SelectedValuePath = "ID";
            FormTimeCmb.DisplayMemberPath = "Name";
            FormTimeCmb.ItemsSource = AppConnect.ModelOdb.FormTime.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ApplicationData.Student student = new ApplicationData.Student
                {
                    Name = NameTxb.Text,
                    Special = SpecialCmb.SelectedItem as Special,
                    YearAdd = YearAddCmb.SelectedItem as YearAdd,
                    GroupName = GroupNameCmb.SelectedItem as GroupName,
                    FormTime = FormTimeCmb.SelectedItem as FormTime
                };
                AppConnect.ModelOdb.Student.Add(student);
                AppConnect.ModelOdb.SaveChanges();

                new CustomMessageBox(1).Show();
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
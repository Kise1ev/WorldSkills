using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для EditStudentGradePage.xaml
    /// </summary>
    public partial class EditStudentGradePage : Page
    {
        private readonly int EventUser = 1;

        public EditStudentGradePage(ApplicationData.Student student)
        {
            InitializeComponent();

            StudentHelpClass.Id = student.ID;
            ApplicationData.Student studentObj = AppConnect.ModelOdb.Student.FirstOrDefault(x => x.ID == student.ID);
            StudentNameTxb.Text = studentObj.Name;

            GradeList.ItemsSource = AppConnect.ModelOdb.Journal.Where(x => x.StudentID == student.ID).ToList();
            GradeList.Columns[0].IsReadOnly = true;
            GradeList.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            History history = new History
            {
                UserID = AccountHelpClass.Id,
                StudentID = StudentHelpClass.Id,
                StatusID = EventUser,
                DateEvent = DateTime.Now
            };
            AppConnect.ModelOdb.History.Add(history);
            AppConnect.ModelOdb.SaveChanges();
            MessageBox.Show("Данные успешно изменены!", "Успешное сохранение!", MessageBoxButton.OK, MessageBoxImage.Information);
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
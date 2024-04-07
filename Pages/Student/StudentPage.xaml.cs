using System;
using System.Linq;
using System.Windows.Controls;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Student
{
    /// <summary>
    /// Логика взаимодействия для StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        public StudentPage()
        {
            InitializeComponent();

            User student = AppConnect.ModelOdb.User.FirstOrDefault(x => x.ID == AccountHelpClass.Id);
            DateEventTxt.Text = Convert.ToString(student.DateIn);
            LoginUserTxt.Text = student.Login;
            StudentNameTxt.Text = student.Name;
            ListGridView.ItemsSource = AppConnect.ModelOdb.User.ToList();
        }
    }
}
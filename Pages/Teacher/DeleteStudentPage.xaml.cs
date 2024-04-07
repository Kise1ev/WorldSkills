using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для DeleteStudentPage.xaml
    /// </summary>
    public partial class DeleteStudentPage : Page
    {
        public DeleteStudentPage()
        {
            InitializeComponent();

            DeleteStudentGrid.ItemsSource = AppConnect.ModelOdb.Student.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = AppConnect.ModelOdb.GroupName.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            DeleteStudentGrid.ItemsSource = AppConnect.ModelOdb.Student.Where(x => x.GroupID == selectGroup).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DeleteStudentGrid.SelectedItems.Count == 0)
                    throw new NullReferenceException("В таблице нет данных!");

                for (int i = 0; i < DeleteStudentGrid.SelectedItems.Count; i++)
                {
                    ApplicationData.Student student = DeleteStudentGrid.SelectedItems[i] as ApplicationData.Student;
                    AppConnect.ModelOdb.Student.Remove(student);
                }

                AppConnect.ModelOdb.SaveChanges();

                GroupCmb.ItemsSource = AppConnect.ModelOdb.GroupName.ToList();
                MessageBox.Show("Студент успешно удален!", "Успешное удаление!", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            catch (NullReferenceException exception)
            {
                MessageBox.Show(exception.Message, "Произошла ошибка удаления!", MessageBoxButton.OK, MessageBoxImage.Error);
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
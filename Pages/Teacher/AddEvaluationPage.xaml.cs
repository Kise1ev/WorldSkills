using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Teacher
{
    /// <summary>
    /// Логика взаимодействия для AddEvaluation.xaml
    /// </summary>
    public partial class AddEvaluationPage : Page
    {
        public AddEvaluationPage()
        {
            InitializeComponent();

            DisciplineCmb.SelectedValuePath = "ID";
            DisciplineCmb.DisplayMemberPath = "Name";
            DisciplineCmb.ItemsSource = AppConnect.ModelOdb.Discipline.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = AppConnect.ModelOdb.GroupName.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = AppConnect.ModelOdb.Student.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEvaluationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int eval = Convert.ToInt32(EvaluationTxt.Text);
                if (eval < 2 && eval > 5)
                    throw new ArgumentException("Введите корректную оценку!");

                Journal journal = new Journal
                {
                    Student = StudentCmb.SelectedItem as ApplicationData.Student,
                    Evaluation = Convert.ToInt32(EvaluationTxt.Text),
                    Discipline = DisciplineCmb.SelectedItem as Discipline,
                    GroupName = GroupCmb.SelectedItem as GroupName
                };
                AppConnect.ModelOdb.Journal.Add(journal);
                AppConnect.ModelOdb.SaveChanges();

                MessageBox.Show("Оценка была успешно добавлена!", "Успешное добавление оценки!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Произошла ошибка ввода данных!", MessageBoxButton.OK, MessageBoxImage.Error);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = AppConnect.ModelOdb.Student.Where(x => x.GroupID == selectGroup).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EvaluationTxt_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e) =>
            e.Handled = "0123456789".IndexOf(e.Text) < 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EvaluationTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int eval = Convert.ToInt32(EvaluationTxt.Text);
            AddEvaluationBtn.IsEnabled = !(eval < 2 && eval > 5);
        }
    }
}
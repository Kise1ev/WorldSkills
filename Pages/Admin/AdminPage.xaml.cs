using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Threading;
using WorldSkills.ApplicationData;

namespace WorldSkills.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();

            GridEvent.ItemsSource = AppConnect.ModelOdb.History.ToList();

            DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += UpdateData;
            timer.Start();
        }

        private void UpdateData(object sender, object e) 
            => GridEvent.ItemsSource = AppConnect.ModelOdb.History.ToList();
    }
}
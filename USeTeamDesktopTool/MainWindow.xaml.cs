using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //TODO: Add process to check for event logs and remove files over a week old
            InitializeComponent();


            if (Properties.Settings.Default.UserClass != "USeTeam")
            {
                DropToTest1Menu.Visibility = System.Windows.Visibility.Hidden;
                CompareEdiMenu.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void SelectUserClassBTN_Clicked(object sender, RoutedEventArgs e)
        {
            LoginWindow newUserClass = new LoginWindow();
            newUserClass.Show();
        }

        private void ExitBTN_Clicked(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

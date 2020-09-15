using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            List<String> CBList = new List<String>();
            CBList.Add("Default");
            CBList.Add("USeTeam");
            UserClassCB.ItemsSource = CBList;


        }

        private void LaunchApplicationBTN_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Add logic here to detail changing class (WILL REQUIRE PROGRAM RESTART)
            if(UserClassCB.SelectedItem.ToString() == "USeTeam")
            {
                if(PasswordPB.Password.ToString() == "Buchanan071615")
                {
                    Properties.Settings.Default.UserClass = UserClassCB.SelectedItem.ToString();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("User class has been changed.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("INCORRECT PASSWORD!");
                }
            }
            else
            {
                Properties.Settings.Default.UserClass = UserClassCB.SelectedItem.ToString();
                Properties.Settings.Default.Save();
                MessageBox.Show("User class has been changed.");
                this.Close();
            }

            //TODO: ADD LOGIC TO CHECK IF TABS ARE OPEN

            MainWindow newWindow = new MainWindow();
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);

            newWindow.ResetMenu(window);
        }
    }
}

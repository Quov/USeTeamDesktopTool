using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
                    MessageBox.Show("User class has been changed. Please note : The GUI changes will not be reflected until the program is restarted.");
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
                MessageBox.Show("User class has been changed. Please note : The GUI changes will not be reflected until the program is restarted.");
                this.Close();
            }
        }
    }
}

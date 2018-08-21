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
        }

        private void LaunchApplicationBTN_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Add logic here to detail changing class (WILL REQUIRE PROGRAM RESTART)

            this.Close();
        }
    }
}

using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            #region MenuControl
            System.Windows.Controls.MenuItem FileMenu = new MenuItem
            {
                Header = "File",
                Name = "FileMenu",
                //HorizontalAlignment = ,
                Height = 22
                //Width  = 90
            };
            MainMenu.Items.Add(FileMenu);

                MenuItem fileExitMenu = new MenuItem
                {
                    Header = "Exit",
                    Name = "ExitMenu",
                    Height = 22
                    //Width = 140
                };
                fileExitMenu.Click += new RoutedEventHandler(ExitBTN_Clicked);
                FileMenu.Items.Add(fileExitMenu);

            MenuItem AnalysisMenu = new MenuItem
            {
                Header = "Analysis",
                Name = "AnalysisMenu",
                Height = 22
                //Width = 120
            };
            MainMenu.Items.Add(AnalysisMenu);

                MenuItem analysisAmazonAudit = new MenuItem
                {
                    Header = "Amazon Audit",
                    Name = "AmazonAuditMenu",
                    Height = 22
                    //Width = 240
                };
                Binding analysisAmazonAuditBinding = new Binding();
                analysisAmazonAuditBinding.Path = new PropertyPath("NewAmazonAuditTabCommand");
                analysisAmazonAudit.SetBinding(MenuItem.CommandProperty, analysisAmazonAuditBinding);
                AnalysisMenu.Items.Add(analysisAmazonAudit);

            MenuItem TestingMenu = new MenuItem
            {
                Header = "Testing",
                Name = "TestingMenu",
                Height = 22
                //Width = 90
            };
            MainMenu.Items.Add(TestingMenu);

            MenuItem SettingsMenu = new MenuItem
            {
                Header = "Settings",
                Name = "SettingsMenu",
                Height = 22
                //Width = 140
            };
            MainMenu.Items.Add(SettingsMenu);

                MenuItem SelectUserClassMenu = new MenuItem
                {
                    Header = "Select UserClass",
                    Name = "SelectUserClassMenu",
                    //HorizontalAlignment = Left,
                    Height = 22
                    //Width = 180
                };
                SelectUserClassMenu.Click += new RoutedEventHandler(SelectUserClassBTN_Clicked);
                SettingsMenu.Items.Add(SelectUserClassMenu);

            if (Properties.Settings.Default.UserClass == "USeTeam")
            {
                //DropToTest1Menu.Visibility = System.Windows.Visibility.Hidden;
                //CompareEdiMenu.Visibility = System.Windows.Visibility.Hidden;
                MenuItem analysisCompareEdiItem = new MenuItem
                {
                    Header = "Compare eLink2 XML",
                    Name = "CompareEdiMenu",
                    //HorizontalAlignment = Left,
                    Height = 22
                    //Width = 240
                };
                Binding analysisCompareBinding = new Binding();
                analysisCompareBinding.Path = new PropertyPath("NewCompareTabCommand");
                analysisCompareEdiItem.SetBinding(MenuItem.CommandProperty, analysisCompareBinding);
                AnalysisMenu.Items.Add(analysisCompareEdiItem);

                MenuItem testingDropToTest1 = new MenuItem
                {
                    Header = "Drop to Test 1",
                    Name = "DropToTest1Menu",
                    //HorizontalAlignment = Left,
                    Height = 22
                    //Width = 240
                };
                Binding dropToTest1Binding = new Binding();
                dropToTest1Binding.Path = new PropertyPath("NewDropToTest1TabCommand");
                testingDropToTest1.SetBinding(MenuItem.CommandProperty, dropToTest1Binding);
                TestingMenu.Items.Add(testingDropToTest1);
            }
            #endregion
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

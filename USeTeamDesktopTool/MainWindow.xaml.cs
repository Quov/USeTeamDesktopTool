using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System;

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

            ResetMenu(this);


            //VersionStatus.Content = version;
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

        public void ResetMenu(Window currentWindow)
        {
            var pb = ((MainWindow)currentWindow).MainMenu;

            //Clears Previous Menu
            int items = pb.Items.Count;
            int i = 0;
            for (i = 0; i < items; i++)
            {
                pb.Items.RemoveAt(0);
            }

            #region MenuControl
            MenuItem FileMenu = new MenuItem
            {
                Header = "File",
                Name = "FileMenu",
                //HorizontalAlignment = ,
                Height = 22
                //Width  = 90
            };
            pb.Items.Add(FileMenu);

                MenuItem fileExitMenu = new MenuItem
                {
                    Header = "Exit",
                    Name = "ExitMenu",
                    Height = 22
                    //Width = 140
                };
                fileExitMenu.Click += new RoutedEventHandler(ExitBTN_Clicked);
                FileMenu.Items.Add(fileExitMenu);

            MenuItem UtilityMenu = new MenuItem
            {
                Header = "Utility",
                Name = "UtilityMenu",
                Height = 22
            };
            pb.Items.Add(UtilityMenu);

                MenuItem mondelezAuditMenu = new MenuItem
                {
                    Header = "Mondelez Container Audit",
                    Name = "MondelezAuditMenu",
                    Height = 22
                };
                Binding mondelezAuditMenuBinding = new Binding();
                mondelezAuditMenuBinding.Path = new PropertyPath("NewMondelezAuditTabCommand");
                mondelezAuditMenu.SetBinding(MenuItem.CommandProperty, mondelezAuditMenuBinding);
                UtilityMenu.Items.Add(mondelezAuditMenu);

            //MenuItem canadaGooseFileHelper = new MenuItem
            //{
            //    Header = "Canada Goose File Helper",
            //    Name = "CanadaGooseMenu",
            //    Height = 22
            //};
            //Binding canadaGooseFileHelperBinding = new Binding();
            //canadaGooseFileHelperBinding.Path = new PropertyPath("NewCanadaGooseTabCommand");
            //canadaGooseFileHelper.SetBinding(MenuItem.CommandProperty, canadaGooseFileHelperBinding);
            //UtilityMenu.Items.Add(canadaGooseFileHelper);

            MenuItem AnalysisMenu = new MenuItem
            {
                Header = "Analysis",
                Name = "AnalysisMenu",
                Height = 22
                //Width = 120
            };
            pb.Items.Add(AnalysisMenu);

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
            pb.Items.Add(TestingMenu);

            MenuItem SettingsMenu = new MenuItem
            {
                Header = "Settings",
                Name = "SettingsMenu",
                Height = 22
                //Width = 140
            };
            pb.Items.Add(SettingsMenu);

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
                //MenuItem MappingMenu = new MenuItem
                //{
                //    Header = "Mappings",
                //    Name = "Mappings",
                //    Height = 22
                //};
                //MainMenu.Items.Add(MappingMenu);

                    //    MenuItem createNewMappingMenu = new MenuItem
                    //    {
                    //        Header = "Create New",
                    //        Name = "CreateNewMapping",
                    //        Height = 22
                    //    };
                    //    Binding mappingNewMapBinding = new Binding();
                    //    mappingNewMapBinding.Path = new PropertyPath("NewElinkMappingTabCommand");
                    //    createNewMappingMenu.SetBinding(MenuItem.CommandProperty, mappingNewMapBinding);
                    //    MappingMenu.Items.Add(createNewMappingMenu);

                    //MenuItem mappingTeamSignOffMenu = new MenuItem
                    //{
                    //    Header = "Generate Team Sign Off Form",
                    //    Name = "TeamSignOffMenu",
                    //    Height = 22
                    //};
                    //Binding teamSignOffBinding = new Binding();
                    //teamSignOffBinding.Path = new PropertyPath("NewTeamSignOffTabCommand");
                    //mappingTeamSignOffMenu.SetBinding(MenuItem.CommandProperty, teamSignOffBinding);
                    //MappingMenu.Items.Add(mappingTeamSignOffMenu);

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

                MenuItem analysisBrpF1Audit = new MenuItem
                {
                    Header = "BRP F1 Audit",
                    Name = "BrpF1AuditMenu",
                    Height = 22
                    //Width = 240
                };
                Binding analysisBrpF1AuditBinding = new Binding();
                analysisBrpF1AuditBinding.Path = new PropertyPath("NewBrpF1AuditTabCommand");
                analysisBrpF1Audit.SetBinding(MenuItem.CommandProperty, analysisBrpF1AuditBinding);
                AnalysisMenu.Items.Add(analysisBrpF1Audit);
            }
            #endregion
        }
    }

}

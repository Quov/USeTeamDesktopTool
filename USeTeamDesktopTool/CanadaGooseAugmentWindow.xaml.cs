using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using USeTeamDesktopTool.Data_Classes;
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for CanadaGooseAugmentWindow.xaml
    /// </summary>
    public partial class CanadaGooseAugmentWindow : Window
    {
        DataGrid lineDG;
        DataGrid headerDG;
        CanadaGooseModel cgData;
        String augmentFilePath;
        CanadaGooseJson allAugments = new CanadaGooseJson();

        public CanadaGooseAugmentWindow(CanadaGooseModel currentCGData, DataGrid headerGrid, DataGrid lineGrid)
        {
            cgData = currentCGData;
            headerDG = headerGrid;
            lineDG = lineGrid;

            InitializeComponent();

            CanadaGooseFunction newCGFunction = new CanadaGooseFunction();
            augmentFilePath = newCGFunction.GetAugmentFilePath();

            allAugments.AllAugments = newCGFunction.LoadAugments(augmentFilePath);      
        }

        public void OpenEditMenu(string augmentType)
        {
            CanadaGooseAugmentModify newModify = new CanadaGooseAugmentModify();
            newModify.Show();
            newModify.ChangeType(augmentType, allAugments);
        }

        private void TariffEditBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenEditMenu("TARIFF");
            
        }

        private void MidEditBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenEditMenu("MID");
        }

        private void FlagEditBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenEditMenu("FLAG");
        }

        //UPDATE RULES

        private void RunAugmentsBTN_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Add process to pull data, run augments and push that data back to the main form.
            UpdateModel();

            foreach(SingleAugment augment in allAugments.AllAugments.Where(x => x.AugmentType == "MID"))
            {

            }
            foreach (SingleAugment augment in allAugments.AllAugments.Where(x => x.AugmentType == "TARIFF"))
            {

            }
        } 

        public void UpdateModel()
        {
            CanadaGooseFunction newCGFunction = new CanadaGooseFunction();
            augmentFilePath = newCGFunction.GetAugmentFilePath();

            allAugments.AllAugments = null;
            allAugments.AllAugments = newCGFunction.LoadAugments(augmentFilePath);
        }
    }


}

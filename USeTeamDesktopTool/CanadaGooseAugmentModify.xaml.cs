using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using USeTeamDesktopTool.Data_Classes;
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for CanadaGooseAugmentModify.xaml
    /// </summary>
    public partial class CanadaGooseAugmentModify : Window
    {
        public CanadaGooseAugmentModify()
        {
            InitializeComponent();
        }

        public void ChangeType(String type, CanadaGooseJson currentAugments)
        {
            AugmentTypeTB.Text = type;
            if(currentAugments != null)
            {
                SelectedAugmentCB.Items.Clear();
                IEnumerable<SingleAugment> selectAugments = currentAugments.AllAugments.Where(x => x.AugmentType == type);
                foreach (SingleAugment augment in selectAugments)
                {
                    SelectedAugmentCB.Items.Add(augment.InitialValue + " TO " + augment.FinalValue);
                }
            }
        }

        private void NewAugmentBTN_Click(object sender, RoutedEventArgs e)
        {
            SelectedAugmentCB.SelectedIndex = -1;
            InitialValueTB.Text = "";
            FinalValueTB.Text = "";
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            CanadaGooseFunction newCGFunction = new CanadaGooseFunction();
            string augmentFilePath = newCGFunction.GetAugmentFilePath();
            newCGFunction.AddAugment(augmentFilePath, AugmentTypeTB.Text.ToString(), InitialValueTB.Text.ToString(), FinalValueTB.Text.ToString());

            CanadaGooseJson allAugments = new CanadaGooseJson();
            allAugments.AllAugments = newCGFunction.LoadAugments(augmentFilePath);

            ChangeType(AugmentTypeTB.Text.ToString(), allAugments);

            //CALL ACTION TO UPDATE PREVIOUS WINDOWS MODEL

        }
    }
}

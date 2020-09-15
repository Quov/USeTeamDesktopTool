using System.Windows;
using System.Windows.Controls;
using USeTeamDesktopTool.Functions;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for SaveTabView.xaml
    /// </summary>
    public partial class ElinkMappingTabView : UserControl
    {

        public ElinkMappingTabView()
        {
            InitializeComponent();
        }

        private void ExcelOutBTN_Click(object sender, RoutedEventArgs e)
        {
            JsonFunctions newJson = new JsonFunctions();
            newJson.LoadSchema(@"C:\Users\abuchanan.LII01\Desktop\TESTING.json");
        }

    }
}

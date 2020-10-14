using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for TestTabView.xaml
    /// </summary>
    public partial class TestTabView : UserControl
    {
        public TestTabView()
        {
            InitializeComponent();

            string curDir = Directory.GetCurrentDirectory();

            #if DEBUG

            #else
            if (Directory.Exists(@"\\pdc-evs-file\US_Common\US_Brokerage\USeTeamDesktopTool\") == true)
            {
                string updateNotes = File.ReadAllText(@"\\pdc-evs-file\US_Common\US_Brokerage\USeTeamDesktopTool\UpdateNotes.html");
                WebBrowserControl.NavigateToString(updateNotes);
            }
            #endif
        }
    }
}

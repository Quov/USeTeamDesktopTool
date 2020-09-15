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
using System.Windows.Shapes;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for BrpAuditFileSelectPopup.xaml
    /// </summary>
    public partial class BrpAuditFileSelectPopup : Window
    {
        public BrpAuditFileSelectPopup()
        {
            InitializeComponent();
        }
        
        public void AddItemsToLB(List<int> fileNos)
        {
            foreach(int fileNo in fileNos)
            {
                FileNoTB.Text += fileNo + "\n";
            }
        }
    }
}

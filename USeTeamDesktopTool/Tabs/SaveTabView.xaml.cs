using System.Windows;
using System.Windows.Controls;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for SaveTabView.xaml
    /// </summary>
    public partial class SaveTabView : UserControl
    {
        public SaveTabView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("IT WORKS");
        }
    }
}

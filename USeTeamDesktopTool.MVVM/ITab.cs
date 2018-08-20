using System;
using System.Windows.Input;

namespace USeTeamDesktopTool.MVVM
{
    public interface ITab
    {
        string Name { get; set; }
        ICommand CloseCommand { get; }
        string Content { get; set; }
        event EventHandler CloseRequested;
    }
}

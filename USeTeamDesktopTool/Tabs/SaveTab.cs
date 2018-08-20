using System;
using USeTeamDesktopTool.MVVM;

namespace USeTeamDesktopTool
{
    public class SaveTab : Tab
    {
        public SaveTab()
        {
            Name = DateTime.Now.ToString();
            Content = "This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString();
        }
    }
}

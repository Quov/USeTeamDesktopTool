using System;
using USeTeamDesktopTool.MVVM;

namespace USeTeamDesktopTool
{
    public class TestTab : Tab
    {
        public TestTab()
        {
            Name = DateTime.Now.ToString();
            Content = "This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString();
        }
    }
}

using System;
using USeTeamDesktopTool.MVVM;

namespace USeTeamDesktopTool
{
    public class MondelezAuditTab : Tab
    {
        public MondelezAuditTab()
        {
            Name = "Mondelez Audit";
            Content = "This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString();
        }
    }
}
﻿using System;
using USeTeamDesktopTool.MVVM;

namespace USeTeamDesktopTool
{
    public class TestTab : Tab
    {
        public TestTab()
        {
            Name = "Patch Notes";
            Content = "This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString() + ". This is a new tab generated at " + DateTime.Now.ToString() +
                ". This is a new tab generated at " + DateTime.Now.ToString();
        }
    }
}

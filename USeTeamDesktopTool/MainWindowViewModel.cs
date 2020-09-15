using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;
using USeTeamDesktopTool.MVVM;

namespace USeTeamDesktopTool
{
    public class MainWindowViewModel
    {
        private readonly ObservableCollection<ITab> tabs;

        public MainWindowViewModel()
        {
            //TODO: Add savetab commans for each tab type
            NewTestTabCommand = new ActionCommand(p => NewTestTab());
            NewDropToTest1TabCommand = new ActionCommand(P => NewDropToTest1Tab());
            NewCompareTabCommand = new ActionCommand(P => NewCompareTab());
            NewAmazonAuditTabCommand = new ActionCommand(P => NewAmazonAuditTab());
            //NewElinkMappingTabCommand = new ActionCommand(P => NewElinkMappingTab());
            NewBrpF1AuditTabCommand = new ActionCommand(P => NewBrpF1AuditTab());
            NewTeamSignOffTabCommand = new ActionCommand(P => NewTeamSignOffTab());
            NewCanadaGooseTabCommand = new ActionCommand(P => NewCanadaGooseTab());
            NewMondelezAuditTabCommand = new ActionCommand(P => NewMondelezAuditTab());

            tabs = new ObservableCollection<ITab>();
            tabs.CollectionChanged += Tabs_CollectionChanged;

            Tabs = tabs;
        }

        public ICommand NewTestTabCommand { get; }
        public ICommand NewDropToTest1TabCommand { get; }
        public ICommand NewCompareTabCommand { get; }
        public ICommand NewAmazonAuditTabCommand { get; }
        //public ICommand NewElinkMappingTabCommand { get; }
        public ICommand NewBrpF1AuditTabCommand { get; }
        public ICommand NewTeamSignOffTabCommand { get; }
        public ICommand NewCanadaGooseTabCommand { get; }

        public ICommand NewMondelezAuditTabCommand { get; }

        public ICollection<ITab> Tabs { get; }

        //TODO: add methods for each tab type
        private void NewTestTab()
        {
            Tabs.Add(new TestTab());
        }

        private void NewDropToTest1Tab()
        {
            Tabs.Add(new DropToTest1Tab());
        }

        private void NewCompareTab()
        {
            Tabs.Add(new CompareTab());
        }

        private void NewAmazonAuditTab()
        {
            Tabs.Add(new AmazonAuditTab());
        }

        //private void NewElinkMappingTab()
        //{
        //    Tabs.Add(new ElinkMappingTab());
        //}

        private void NewBrpF1AuditTab()
        {
            Tabs.Add(new BrpF1AuditTab());
        }

        private void NewTeamSignOffTab()
        {
            Tabs.Add(new TeamSignOffTab());
        }

        private void NewCanadaGooseTab()
        {
            Tabs.Add(new CanadaGooseTab());
        }

        private void NewMondelezAuditTab()
        {
            Tabs.Add(new MondelezAuditTab());
        }

        private void Tabs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ITab tab;

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    tab = (ITab)e.NewItems[0];
                    tab.CloseRequested += OnTabCloseRequested;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    tab = (ITab)e.OldItems[0];
                    tab.CloseRequested -= OnTabCloseRequested;
                    break;
            }
        }

        private void OnTabCloseRequested(object sender, EventArgs e)
        {
            Tabs.Remove((ITab)sender);
        }
    }
}

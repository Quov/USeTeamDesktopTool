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
            NewSaveTabCommand = new ActionCommand(p => NewSaveTab());
            NewTestTabCommand = new ActionCommand(p => NewTestTab());
            NewDropToTest1TabCommand = new ActionCommand(P => NewDropToTest1Tab());
            NewCompareTabCommand = new ActionCommand(P => NewCompareTab());

            tabs = new ObservableCollection<ITab>();
            tabs.CollectionChanged += Tabs_CollectionChanged;

            Tabs = tabs;
        }

        public ICommand NewSaveTabCommand { get; }
        public ICommand NewTestTabCommand { get; }
        public ICommand NewDropToTest1TabCommand { get; }
        public ICommand NewCompareTabCommand { get; }

        public ICollection<ITab> Tabs { get; }

        //TODO: add methods for each tab type
        private void NewSaveTab()
        {
            Tabs.Add(new SaveTab());
        }

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

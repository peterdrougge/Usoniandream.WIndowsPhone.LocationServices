using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Usoniandream.WindowsPhone.LocationServices.Models;

namespace Usoniandream.WindowsPhone.LocationServices.Tester
{
    public class GenericPivotItem
    {
        public string Header { get; set; }
        public string Source { get; set; }

        private ObservableCollection<ILocation> items;
        public ObservableCollection<ILocation> Items { get { if (items == null) items = new ObservableCollection<ILocation>(); return items; } set { items = value; } }
    }
}

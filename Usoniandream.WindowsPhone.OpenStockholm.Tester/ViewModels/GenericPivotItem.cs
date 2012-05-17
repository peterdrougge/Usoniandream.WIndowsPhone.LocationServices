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
    public class GenericPivotItem : GenericPivotItem<IModel>
    {
    }
    public class GenericPivotItem<T>
    {
        public string Header { get; set; }
        public string Source { get; set; }

        private ObservableCollection<T> items;
        public ObservableCollection<T> Items { get { if (items == null) items = new ObservableCollection<T>(); return items; } set { items = value; } }
    }
}

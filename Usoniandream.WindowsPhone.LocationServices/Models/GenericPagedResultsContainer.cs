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
using System.Collections.Generic;
using System.Linq;

namespace Usoniandream.WindowsPhone.LocationServices.Models
{
    public class GenericPagedResultsContainer<T>
    {
        public int MaxHits { get; set; }
        public int PageSize { get; set; }
        public int StartIndex { get; set; }
        public IEnumerable<T> Items { get; set; }
        public bool HasMorePages 
        { 
            get
            {
                if (MaxHits > (StartIndex + PageSize))
                {
                    return true;
                }
                return false;
            }
        }
    }
}

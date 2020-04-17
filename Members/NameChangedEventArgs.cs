using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    public class NameChangedEventArgs : EventArgs   //dzieciczenia z klasy EventArgs
    {
        // dla wygody    wpisujemy "prop"  i 2 x klikamy "Tab"       
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
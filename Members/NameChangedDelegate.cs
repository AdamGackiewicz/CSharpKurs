using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
    
    //15.04.2020 17:22   zablokowane - pozostałość po wcześniejszym etapie kursu przy kodzystaniu z delegat
    //public delegate void NameChangedDelegate(string existingName,string newName);


}  
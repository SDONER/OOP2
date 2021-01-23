using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Individual:Customer // inheritence ile müşteri sınıfına ait olduğu belirtiliyor...
    {
       
        
        public string TcNum { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}

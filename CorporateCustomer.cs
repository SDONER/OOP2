using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer // inheritence ile müşteri sınıfına ait olduğu belirtiliyor...
    {
        public string CustomerNum { get; set; }
        public string VergiNum { get; set; }
        public string CompanyName { get; set; }
        
    }
}

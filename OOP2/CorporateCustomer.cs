using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance-Kalıtım(miras)
    class CorporateCustomer:Customer//Tüzel Müşteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

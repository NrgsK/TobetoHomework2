using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        // Bir müşterinin özelliklerini tutmak için kullanılan nesnedir.
        public int Id { get; set; } // Property
        public string FirstName { get; set; }
        //public string FirstName;
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

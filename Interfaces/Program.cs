using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface isimlendirme standardı "I" ile başlamasıdır.
        }
    }
    interface IPerson
    {
        // Soyut nesne - tek başına bir anlam ifade etmez.
        // interface nin amacı bir temel temel nesne oluşturup bütün nesneleri ondan implemente etmektir.
        int Id { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }
    }
    class Customer : IPerson // IPersonda tanımlanan herşeyi bu sınıflarda görebiliriz.
    {
        // Somut nesne
        // Interface de yazılan özelliklerin karşılığını implement edilen sınıfta tanımlamalısın.
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Adress { get; set; } // Müşteriye ait ayrı bir özellik

    }
    class Student : IPerson
    {
        // Somut nesne
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Department { get; set; } // Öğrenciye ait ayrı bir özellik
    }
}

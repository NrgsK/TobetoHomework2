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
            PersonManager manager = new PersonManager();

            //Customer customer= new Customer{ Id = 1, FirstName = "Nergis", LastName = "Ketenci", Adress = "Rize" };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "Ketenci",
                Department = "Science",
            };
            manager.Add(new Customer { Id = 1, FirstName = "Nergis", LastName = "Ketenci", Adress = "Rize" });
            manager.Add(student);
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        // Soyut nesne - tek başına bir anlam ifade etmez.
        // interface nin amacı bir temel temel nesne oluşturup bütün nesneleri ondan implemente etmektir.
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson // IPersonda tanımlanan herşeyi bu sınıflarda görebiliriz.
    {
        // Somut nesne
        // Interface de yazılan özelliklerin karşılığını implement edilen sınıfta tanımlamalısın.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; } // Müşteriye ait ayrı bir özellik

    }
    class Student : IPerson
    {
        // Somut nesne
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; } // Öğrenciye ait ayrı bir özellik
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            // Bir nesne de parametre olabilir.
            //public void Add(Customer customer) --> student gönderemiyoruz. Tanımladığımız IPerson interfacesini parametre olarak göndermeliyiz


            Console.WriteLine(person.FirstName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class amacı yapılmak istenen işlemleri gruplara ayırmak, bu gruplar üzerinden işlemler yapmak ve rahat bir şekilde bu gruplara ulaşmak.
            //Sınıfları kullanabilmek için main de birer örnek oluşturmak gerekir.
            CustomerManager customerManager = new CustomerManager(); // Class ın bir örneği oluşturuldu
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            // Çalışacağımız nesne ile ilgili önce örnek oluşturuyoruz sonrasında içerisindeki metotları çağırıyoruz.
            productManager.Add();
            productManager.Update();



            Console.ReadLine();

        }
    }



}

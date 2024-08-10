using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi
    {
        // Propertyler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Konsol ekranına ad ve soyadı yazdıran metot
        public void Bilgiler()
        {
            Console.WriteLine("\nAdı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
        }
    }
    // Ogrenci sınıfı BaseKisi'den miras alır
    public class Ogrenci : BaseKisi
    {
        public int _ogrenciNo { get; set; }
        public void OgrenciNo()
        {
            Bilgiler(); // BaseKisi'den gelen metodu çağırır
            Console.WriteLine("Öğrenci No: " + _ogrenciNo);
        }
    }
    // Ogretmen sınıfı BaseKisi'den miras alır
    public class Ogretmen : BaseKisi
    {
        public int _maas { get; set; }
        public void Maas()
        {
            Bilgiler(); // BaseKisi'den gelen metodu çağırır
            Console.WriteLine("Maaş: " + _maas +"TL");
        }
    }
}


using Inheritance;

// Öğretmen nesnesi oluşturuluyor
Ogrenci ogrenci = new Ogrenci
{
    Ad = "Ali",
    Soyad = "Yılmaz",
    _ogrenciNo = 4567
};

// Öğretmen nesnesi oluşturuluyor
Ogretmen ogretmen = new Ogretmen
{
    Ad = "Ayşe",
    Soyad = "Kara",
    _maas = 50000
};

ogrenci.OgrenciNo();
ogretmen.Maas();
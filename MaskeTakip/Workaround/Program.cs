// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Merhaba!");


//Degiskenler();

Vatandas vatandas1 = new Vatandas();

SelamVer("Engin");
SelamVer("Ahmet");
SelamVer("Ayse");
SelamVer();

int sonuc = Topla(6,58);

//diziler /arrays
String ogrenci1 = "Engin";
String ogrenci2 = "Kerem";
String ogrenci3 = "Berkay";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "Ilker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);    
}

string[] sehirler1 = new[] {"Ankara","Istanbul","Izmir"};
string[] sehirler2 = new[] {"Bursa","Antalya","Diyarbakir"};

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person(); 
person1.FirstName = "Tarık";
person1.LastName = "Yılmaz";
person1.DateOfBirtYear = 1985;
person1.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "Murat";

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//MyList odevi icin for-array kullaniminda bulunurdum :(
List<string> yeniSehirler1 = new List<string> { "Ankara 1","Istanbul 1","Izmir 1" };
yeniSehirler1.Add(item: "Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



//Resharper eklentisi
static void SelamVer(string isim="Isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5 , int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc.ToString());
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Selam";
    double tutar = 100000; //dbden gelir
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Engin";
    string soyad = "Demirog";
    int dogumYili = 1987;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);

    Console.WriteLine(tutar * 1.18);

    Console.ReadLine();
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set;}
    public int DogumYili { get; set;}
    public long TcNo { get; set;}
}
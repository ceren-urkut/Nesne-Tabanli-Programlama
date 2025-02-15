// See https://aka.ms/new-console-template for more information
/*
 Çoklu
yorum
satırı
*/

//Comment kısayol tuşu = ctrl + K + C
//Uncomment kısayol tuşu = ctrl + K + U

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Lütfen isminizi giriniz:");
//string isim = Console.ReadLine();

//// "\n" ifadesi enter anlamına gelir ve boşluk bırakır bir satır

//Console.WriteLine("\nHoşgeldiniz " + isim);
//Console.ReadKey();

//// F5 tuşu ile kodu çalıştırabilirsin


// İKİ SAYI ARASINDAKİ SAYILARIN TOPLAMI

// 1. Yol   (100*4=400)
//int toplam = 0;

//for (int i = 10; i < 20; i++)
//{
//    Console.WriteLine(i);
//    toplam += i;
//    // toplam = toplam +i;
//}
//Console.WriteLine("Sayıların Toplamı:" + toplam);

// Ctrl + K + D (Design) -> Kodları düzenlemek için

// 2. Yol   (100+5=105)
// Toplam Metodu

//static int toplammetotu(int sayi1, int sayi2)
//{
//    int toplam = 0;
//    for (int i = sayi1; i < sayi2; i++)
//    {
//        toplam += i;
//    }
//    return toplam;

//}

//int sonuc1 = toplammetotu(10, 20);
//console.writeline("sonuc1: " + sonuc1);

// ÇARPIM METOTU

//static int carpimMetotu(int x, int y)
//{
//    int carpim = x * y;
//    return carpim;

//}

//Console.WriteLine("Sonuc: " + carpimMetotu(10, 20));

//MAX DEĞERİNİ BULMA
//static int max(int sayi1, int sayi2)
//{
//    int sonuc;
//    if (sayi1 > sayi2) { sonuc = sayi1; }
//    else { sonuc = sayi2; }
//    return sonuc;
//}

//int x = 45;
//int y = 32;
//int z = max(x, y);

//Console.WriteLine(x + " ile " + y + " den büyük olanı " + z + "dir.");


// NOTU HARF NOTUNA ÇEVİREN METOT - Void
//static void notYazdir(double ort)
//{
//    if (ort >= 90) { Console.WriteLine("A"); }
//    else if (ort >= 80) { Console.WriteLine("B"); }
//    else if (ort >= 70) { Console.WriteLine("C"); }
//    else if (ort >= 60) { Console.WriteLine("D"); }
//    else { Console.WriteLine("Seneye görüşürüz"); }
//}

//Console.WriteLine("Not Ortalamanızı Giriniz: ");
//double ortalamam = Convert.ToDouble(Console.ReadLine());
//notYazdir(ortalamam);

//NOTU HARF NOTUNA ÇEVİREN METOT - char
//static char notYazdir(double ort)
//{
//    if (ort >= 90) { return 'A'; }
//    else if (ort >= 80) { return 'B'; }
//    else if (ort >= 80) { return 'C'; }
//    else if (ort >= 80) { return 'D'; }
//    else return 'F';
//}

//Console.WriteLine("not ortalamanızı giriniz: ");
//double ortalamam = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(notYazdir(ortalamam));


// ARTIRMA METODU

//int x = 5;

//Console.WriteLine("x in metottan önceki değeri: " + x);
//artir(x);
//Console.WriteLine("x in metottan sonraki değeri: " + x);

//static void artir(int x)
//{
//    x++;
//    Console.WriteLine("x in değeri(metot için): " + x);
//}

// 3. HAFTA

// EBOB (en büyük ortak bölen)              ANLAMADIM EBOB U
/*
ebob(10,20) = 10
10 -> 2,5,10
20 -> 2,4,5,10,20

ebob(12,18) = 6
12 -> 2,3,4,6,12
18 -> 2,3,6,9,18
*/

//Console.WriteLine("Birinci sayıyı giriniz: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("İkinci sayıyı giriniz: ");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("İki sayının EBOBU: " + obeb(sayi1, sayi2));

//static int obeb(int s1, int s2)
//{
//    int obebi = 0;
//    int bolen = 2;

//    while (bolen <= s1 && bolen <= s2) //2<=10 and 2<=20  // 3<=10 and 3<=20  //&& = and
//    {
//        if (s1 % bolen == 0 && s2 % bolen == 0) // 10%2==0 and 20%2==0, // 10%5==0 and 20%5==0
//        {
//            obebi = bolen; //obebi = 2, 5, 10
//        }
//        bolen++;  //bolen = 2+1=3, 4, 5, 6, 7, 8, 9, 10, 11
//    }
//    return obebi;
//}


// Verilen sayıların rakamları toplamını geri döndüren metot

//Console.WriteLine("Lütfen bir sayı giriniz: ");  //45 => 4+ 5 = 9
//int sayi = Convert.ToInt32(Console.ReadLine());
//// sadece 2 basamaklı sayılar için çalışıyor
//static int rakamlariToplami(int sayi)
//{
//    int toplam = 0;
//    int birler = sayi % 10;
//    Console.WriteLine(birler);
//    int onlar = sayi / 10;
//    Console.WriteLine(onlar);
//    toplam = birler + onlar;

//    return toplam;
//}
//Console.WriteLine("Sayının rakamlar toplamı: " + rakamlariToplami(sayi));

//Console.WriteLine("Lütfen bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//// sadece 3 basamaklılar için çalışıyor
//static int rakamlariToplami3(int sayi)
//{
//    int toplam = 0;
//    int birler = sayi % 10;  // 345 % 10 = 5
//    Console.WriteLine("Birler: " + birler);
//    int onlar = (sayi / 10) % 10;  // 345 / 10 = 34 , 34 % 10 = 4
//    Console.WriteLine("Onlar: " + onlar);
//    int yuzler = sayi / 100;  // 345 / 100 = 3
//    Console.WriteLine("Yüzler: " + yuzler);
//    toplam = birler + onlar + yuzler;

//    return toplam;
//}
//Console.WriteLine("Sayının rakamlar toplamı: " + rakamlariToplami3(sayi));

//static int rakamlariToplami(int sayi)
//{
//    int toplam = 0;
//    int birler = sayi % 10;  // 345 % 10 = 5
//    Console.WriteLine("Birler: " + birler);
//    Console.WriteLine("Sayi: " + sayi);
//    int onlar = (sayi / 10) % 10;  // 345 / 10 = 34 , 34 % 10 = 4
//    Console.WriteLine("Onlar: " + onlar);
//    Console.WriteLine("Sayi: " + sayi);
//    int yuzler = sayi / 100;  // 345 / 100 = 3
//    Console.WriteLine("Yüzler: " + yuzler);
//    Console.WriteLine("Sayi: " + sayi);
//    toplam = birler + onlar + yuzler;

//    return toplam;
//}
//Console.WriteLine("Sayının rakamlar toplamı: " + rakamlariToplami(sayi));


//Console.WriteLine("Lütfen bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//static int rakamlariToplamiSon(int sayi)
//{
//    int toplam = 0;

//    while (sayi != 0)  // sayı sıfıra eşit değilse çalışsın
//    {
//        int rakam = sayi % 10;  // 345 % 10 = 5, 34 % 10 = 4, 3 % 10 =  3 (!!!) 
//        Console.WriteLine("Rakam: " + rakam);
//        toplam += rakam;    // toplam = 5 + 4 + 3
//        sayi = sayi / 10;   // sayi = 345 / 10 = 34, 34 / 10 = 3, 3 / 10 = 0 (!!!)
//        Console.WriteLine("Sayi: " + sayi);
//    }
//    return toplam;
//}
//Console.WriteLine("Sayının rakamlar toplamı: " + rakamlariToplamiSon(sayi));


// Mükemmel Sayı = kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayi.

//Console.WriteLine("Bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//int toplam = 0;

//for (int i = 1; i < sayi; i++)  // i = bolen
//{
//    if (sayi % i == 0)
//    {
//        Console.WriteLine("Tam bolen: " + i);
//        toplam += i;
//    }
//}

//if (toplam == sayi) { Console.WriteLine("Sayi mükemmeldir"); }
//else { Console.WriteLine("Sayi mükemmel değildir"); }


//Console.WriteLine("Bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//mukemmelMi(sayi);

//static void mukemmelMi(int sayi)
//{

//    int toplam = 0;
//    int sayac = 0;
//    for (int i = 1; i < sayi; i++)  // i = bolen
//    {
//        if (sayi % i == 0)
//        {
//            Console.WriteLine("Tam bolen: " + i);
//            toplam += i;
//            sayac++;
//        }
//    }
//    if (toplam == sayi) { Console.WriteLine("Sayi mükemmeldir"); }
//    else { Console.WriteLine("Sayi mükemmel değildir"); }
//    Console.WriteLine("Tam bolen sayısı: " + sayac);
//}



// 4. HAFTA

//Console.Write("Fahreneit değerini giriniz:");
//double sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(fah2cel(sayi1));

//static double fah2cel(double sayi)
//{
//    //return sayi - 32 * 5 / 9; // hatalı
//    return (sayi - 32) * 5 / 9;
//}

//Console.Write("Celcius değerini giriniz:");
//double sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(cel2fah(sayi1));

//static double cel2fah(double sayi)
//{
//    return sayi * 9 / 5 + 32 ;
//}


// ARRAY

//string[]  cars0;
//string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };

//int[] MyNum = { 10, 20, 30, 40 };

//string[] cars2 = { "Volvo", "BMW", "Ford", "25" }; //hatalı

//string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
//Console.WriteLine(cars1[3]);

//cars1[0] = "Opel";
//Console.WriteLine(cars1[0]);

//Console.WriteLine(cars1.Length);

//int[] sayilar = { 10, 20, 30, 40 };
//Console.WriteLine(sayilar[0]);

//sayilar[0] = 0;
//Console.WriteLine(sayilar[0]);

////Console.WriteLine(sayilar[6]); // IndexOutOfRangeException (hatalı) //index değerine max 3 yazılabilir

//Console.WriteLine(sayilar); // sadece sınıf bilgisi gelir. Elemanlar yazılmaz

// Dizi elemanlarına değer atama ve yazdırma

//int[]  dizi = new int[10];   // 10 elemanlı boş bir dizi
//Console.WriteLine(dizi[2]);
//sayısal değerle kurulmuş dizilere atama yapmazsan 0 gelir

//arraylerin başlangıç değeri(default) bir şey atanmadıysa 0 olur !!!!

// 0 - 9
//for (int i = 0; i < dizi.Length; i++)
//{
//    dizi[i] = i;
//    Console.WriteLine("dizi["+ i + "] = " + dizi[i]);
//}

// 1 - 10
//for (int i = 1; i <= 10; i++)
//{
//    dizi[i-1] = i;
//    Console.WriteLine("dizi[" + (i-1) + "] = " + dizi[i-1]);
//}

// dizinin elemanlarının toplamını yazdıran program

//int[] dizi = new int[10];
//int toplam = 0;

//for (int i = 0; i < 10; i++)
//{
//    dizi[i] = i;
//    Console.WriteLine(dizi[i]);
//    toplam += dizi[i];
//}
//Console.WriteLine("Toplam: " + toplam);

// Dizinin elemanlarını yazdırma

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//1. Yol
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}

//2. Yol 
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("");

//Array.Sort(cars);  // a -> z  //sort sırala demek
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}

//int[] sayilar = { 100, 25, 75, -9 };

//Array.Sort(sayilar);  // k -> b
//foreach (int i in sayilar)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(sayilar.Max());  // 100 
//Console.WriteLine(sayilar.Min());  // -9
//Console.WriteLine(sayilar.Sum());  // 191

//Console.WriteLine(sayilar.Length);  // 4 
//Console.WriteLine(sayilar.Count());  // 4 

// Çok Boyutlu Diziler

//int[,] sayilar = { { 1,4,2},{ 3,6,8} };  //çok boyutlu dizi olduğunu anlamak için iki köşeli parantezin arasına virgül koy
//Console.WriteLine(sayilar[0]);  // hatalı
//Console.WriteLine(sayilar[0,1]);  // 4 
//Console.WriteLine(sayilar[1,1]);  //6
//Console.WriteLine(sayilar[1,2]);  //8
//Console.WriteLine(sayilar[2, 2]);  // IndexOutOfRangeException

//Console.WriteLine(sayilar[0, 1]);
//sayilar[0, 1] = 5;
//Console.WriteLine(sayilar[0, 1]);

//foreach (var i in sayilar)
//{
//    Console.WriteLine(i);
//}

// Değişkenler ve Diziler

//int x = 1;
//int[] y = new int[2];
//string z = "ceren";

//Console.WriteLine("Metotdan önce");
//Console.WriteLine("x: " + x);
//Console.WriteLine("y: " + y[0]);
//Console.WriteLine("z: " + z);

//metot(x, y, z);

//Console.WriteLine("Metotdan sonra");
//Console.WriteLine("x: " + x);
//Console.WriteLine("y: " + y[0]);
//Console.WriteLine("z: " + z);


//static void metot(int x, int[] y, string z)
//{
//    x = 1000;
//    y[0] = 100;
//    z = "CEREN";

//    Console.WriteLine("Metodun içinde");
//    Console.WriteLine("x: " + x);
//    Console.WriteLine("y: " + y[0]);
//    Console.WriteLine("z: " + z);

//}

//5. HAFTA

//Nokta nokta1 = new Nokta();   //"nokta1" ile yazılan yer nesnedir.nesne oluştururken "new" kelimesi kullanılır
//nokta1.x = 10;
//nokta1.y = 20;
//Console.WriteLine("Noktanın Koordinatları: (" + nokta1.x + ","
//    + nokta1.y + ")");
//class Nokta  //büyük harfle yazılan "Nokta" class yani sınıftır
//{
//    public int x;
//    public int y;
//}
// kaç tane new keli

//Araba arabam = new Araba();
//arabam.renk = "Kırmızı";
//arabam.marka = "Mercedes";
//arabam.model = "GLA";
//arabam.vitesTipi = "Otomatik";
//arabam.yakitTipi = "Hibrit";
//arabam.kapiSayisi = 4;
//arabam.yili = 2024;
//arabam.km = 10000;

//Console.WriteLine("Hayalimdeki Araba \nRengi: " + arabam.renk 
//    + "\nMarkası: " + arabam.marka 
//    + "\nModeli: " + arabam.model
//    + "\nVites Tipi: " + arabam.vitesTipi
//    + "\nYakıt Tipi: " + arabam.yakitTipi
//    + "\nKapı Sayısı: " + arabam.kapiSayisi
//    + "\nYılı: " + arabam.yili
//    + "\nKM: " + arabam.km);

//class Araba
//{
//    public string renk;
//    public string marka;
//    public string model;
//    public string vitesTipi;
//    public string yakitTipi;
//    public int kapiSayisi;
//    public int yili;
//    public int km;
//}


//Overload

//int buyukSayi = Math.Max(10, 20);
//Console.WriteLine(buyukSayi);

//double buyukSayi2 = Math.Max(10.5, 20.8);
//Console.WriteLine(buyukSayi2);

//Console.WriteLine(Overloading.bmax(10,25));
//Console.WriteLine(Overloading.bmax(10.8, 20.9));

////Console.WriteLine(Overloading.bmax(10.5, 25.2, 14.8));  //hatalı
//Console.WriteLine(Overloading.bmax(10, 25, 12));

//class Overloading
//{
//    public static int bmax(int s1, int s2)
//    {
//        if (s1 > s2) { return s1; }
//        else { return s2; }
//    }
//    public static double bmax(double s1, double s2)
//    {
//        if (s1 > s2) { return s1; }
//        else { return s2; }
//    }
//    public static double bmax(double s1, double s2, double s3)
//    { return bmax(bmax(s1, s2), s3); }
//    //public static int bmax(int s1, int s2, int s3)
//    //{ return bmax(bmax(s1, s2), s3); }
//}

// Random

//Random rnd = new Random();
//int sayi = rnd.Next();
//Console.WriteLine(sayi);

//Console.WriteLine(rnd.Next(1,101)); // (Başlangıç değeri, Bitiş değeri(Dahil değil)

// Sayi Tahmin Oyunu

//Random rnd = new Random();
//int tahminEdilenSayi = rnd.Next(1, 101);

//Console.WriteLine("1 ile 100 arasında sayı giriniz !!!");
//int tahmin = -1;
//int sayac = 1;

//while (tahmin != tahminEdilenSayi)
//{
//    Console.Write("Tahmininiz: ");
//    tahmin = Convert.ToInt32(Console.ReadLine());

//    if (tahmin == tahminEdilenSayi)
//    {
//        Console.WriteLine("Tebrikler " + sayac + ". denemede bildiniz!!!");
//    }
//    else if (tahmin < tahminEdilenSayi)
//    {
//        Console.WriteLine("Daha büyük bir sayı giriniz!");
//    }
//    else { Console.WriteLine("Daha küçük bir sayı giriniz!"); }
//    sayac++;
//}

// 6. HAFTA

//Cember cember1 = new Cember();
//Console.WriteLine("Yarıçapı: " + cember1.yaricap);

//cember1.yaricap = 10;
//Console.WriteLine("Yarıçapı: " + cember1.yaricap);

////cember1.yaricapGuncelle(15);
////Console.WriteLine("Yarıçapı: " + cember1.yaricap);

//Console.WriteLine("Alanı: " + cember1.alanHesapla());
//Console.WriteLine("Çevresi: " + cember1.cevreHesapla());

//Cember cember2 = new Cember(15);
//Console.WriteLine("\nYarıçapı: " + cember2.yaricap);
//Console.WriteLine("Alanı: " + cember2.alanHesapla());
//Console.WriteLine("Çevresi: " + cember2.cevreHesapla());

// Referans

//int i = 1;
//int j = 2;

//i = j;
//i++;
//Console.WriteLine("i: " + i);   // 3
//Console.WriteLine("j: " + j);   // 2

//Cember c1 = new Cember(5);
//Cember c2 = new Cember(10);

//c1 = c2;
//c1.yaricap = 25;
//c2.yaricap = 35;
//Console.WriteLine("\nC1 in yarıçapı: " + c1.yaricap);  //25
//Console.WriteLine("C2 in yarıçapı: " + c2.yaricap);  //25



//public class Cember
//{
//    public double yaricap = 1;

//    //constructor kısayol => ctor + tab + tab
//    public Cember()  //temel-parametresiz constructor
//    {

//    }
//    public Cember(double yaricap)
//    {
//        this.yaricap = yaricap;
//    }
//    //public Cember(double yaricap2)
//    //{
//    //   yaricap = yaricap2;
//    //}
//    public double alanHesapla() { return yaricap * yaricap * Math.PI; }
//    public double cevreHesapla() { return 2 * yaricap * Math.PI; }
//    public void yaricapGuncelle(double y) { yaricap = y; }

//}


// TV

//TV tv1 = new TV();
//tv1.ac();
//tv1.kanaliAyarla(53);
//tv1.sesiAyarla(5);

//Console.WriteLine("Tv1 Kanal: " + tv1.kanal + " Ses: " + tv1.sesSeviyesi);

//TV tv2 = new TV();
//tv2.ac();
//tv2.kanaliAyarla(25);
//tv2.sesiAyarla(2);

//tv2.kanalYukari();
//tv2.kanalYukari();
//tv2.sesYukari();

//Console.WriteLine("Tv2 Kanal: " + tv2.kanal + " Ses: " + tv2.sesSeviyesi);


//public class TV
//{
//    public int kanal = 1;  // 1-120
//    public int sesSeviyesi = 1;  // 1-7
//    bool acikMi = true;
//    public TV()
//    {

//    }
//    public void ac() { acikMi = true; }
//    public void kapat() { acikMi = false; }

//    public void kanaliAyarla(int yeniKanal)
//    {
//        if (acikMi && yeniKanal >= 1 && yeniKanal <= 120)
//        {
//            kanal = yeniKanal;
//        }
//    }
//    public void sesiAyarla(int yeniSes)
//    {
//        if (acikMi && yeniSes >= 1 && yeniSes <= 7)
//        {
//            sesSeviyesi = yeniSes;
//        }
//    }
//    public void kanalYukari() { if (acikMi && kanal < 120) { kanal++; } }
//    public void kanalAsagi() { if (acikMi && kanal > 1) { kanal--; } }
//    public void sesYukari() { if (acikMi && sesSeviyesi < 7) { sesSeviyesi++; } }
//    public void sesAsagi() { if (acikMi && sesSeviyesi > 1) { sesSeviyesi--; } }

//}

// 7. HAFTA

//Ogrenci ogr1 = new Ogrenci();

//Console.WriteLine("Adı: " + ogr1.adi);
//Console.WriteLine("Yaşı: " + ogr1.yas);
//Console.WriteLine("YBS öğrencisi mi: " + ogr1.YBSMi);
//Console.WriteLine("Cinsiyet: " + ogr1.cinsiyet);

//public class Ogrenci
//{
//    public string adi;  // Null
//    public int yas;    // 0
//    public bool YBSMi;   // False
//    public char cinsiyet;    //   \0 =>  ascii = 0 ,  space boşluk => ascii = 32

//}

//Adı:   
//Yaşı: 0   
//YBS öğrencisi mi: False
//Cinsiyet:


// DateTime

//DateTime simdi = DateTime.Now;
//Console.WriteLine("Şimdi: " + simdi);   //Şimdi: 2.11.2024 20:01:41
//Console.WriteLine("");
//Console.WriteLine("Bugün: " + simdi.DayOfWeek);  //Bugün: Saturday
//Console.WriteLine("Sadece Tarih: " + simdi.ToShortDateString());   //Sadece Tarih: 2.11.2024
//Console.WriteLine("Sadece Saat: " + simdi.ToShortTimeString());   //Sadece Saat: 20:04

//simdi = simdi.AddYears(10);
//Console.WriteLine("Gelecekte bugun: " + simdi);   //Gelecekte bugun: 2.11.2034 20:06:14

//DateTime dt = new DateTime(2025, 10, 26, 20, 35, 12);
//Console.WriteLine("Tarih: {0}", dt);      //Tarih: 26.10.2025 20:35:12    
//Console.WriteLine("Tarih: {0:f}", dt);      // Tarih: 26 Ekim 2025 Pazar 20:35
//Console.WriteLine("Gün: {0:dddd}", dt);      //Gün: Pazar
//Console.WriteLine("Sadece Tarih: {0:D}", dt);      //Sadece Tarih: 26 Ekim 2025 Pazar
//Console.WriteLine("Sadece Saat: {0:T}", dt);            //Sadece Saat: 20:35:12


// Random

//Random r1 = new Random(10);
//Random r2 = new Random(100);

////Console.WriteLine(r1.Next(1000));   // max 1000 e kadar rastgele sayı türetir

//for (int i = 0; i < 10; i++)
//{
//    Console.Write(r1.Next(1000)+" ");
//}
//Console.WriteLine("");
//for (int i = 0; i < 10; i++)
//{
//    Console.Write(r2.Next(1000)+" ");
//}

//Console.WriteLine(" ");
//for (int i = 0; i < 5; i++)
//{
//    Console.Write(r1.Next(1000) + " ");
//}
//Console.WriteLine("");
//for (int i = 0; i < 5; i++)
//{
//    Console.Write(r2.Next(1000) + " ");
//}


//*
//* *
//* * *
//* * * *
//* * * * *

//Console.WriteLine(new String('*',5));

//for (int i = 1; i < 6; i++)
//{
//    Console.WriteLine(new String('*', i));
//}

//   *
//  * *
// * * *
//* * * *





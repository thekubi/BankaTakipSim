using BankaTakipSim;
Musteri musteri1 = new Musteri();
musteri1.tcNo = "13426205744";
musteri1.adi = "Kubilay Alp";
musteri1.soyadi = "Türk";
musteri1.yas = 20;
musteri1.meslek = "Barista";

Musteri musteri2 = new Musteri();
musteri2.tcNo = "18675698622";
musteri2.adi = "Hamza";
musteri2.soyadi = "Saygın";
musteri2.yas = 56;
musteri2.meslek = "Polis";

Musteri musteri3 = new Musteri();
musteri3.tcNo = "75684965266";
musteri3.adi = "Gamze";
musteri3.soyadi = "Kara";
musteri3.yas = 33;
musteri3.meslek = "Yazar";

Musteri[] musteriler = new Musteri[] {musteri1, musteri2 , musteri3};

foreach (Musteri musteri in musteriler)
{
    Console.WriteLine(musteri.tcNo);
    Console.WriteLine(musteri.adi);
    Console.WriteLine(musteri.soyadi);
    Console.WriteLine(musteri.yas);
    Console.WriteLine(musteri.meslek);
    Console.WriteLine("--------------");
}

musteriManager musterimanager = new musteriManager();
musterimanager.musteriEkle(musteri1);
musterimanager.musteriEkle(musteri2);
musterimanager.musteriEkle(musteri3);

Console.WriteLine("-------------------");

musteriManager musterimanager1 = new musteriManager();
musterimanager.musteriSil(musteri1);
musterimanager.musteriSil(musteri2);
musterimanager.musteriSil(musteri3);




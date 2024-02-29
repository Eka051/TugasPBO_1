using TugasPBO;

internal class Program
{
    public static void Main(string[] args)
    {
        // MOBIL SEDAN
        mobilSedan honda = new mobilSedan("Honda Civic", "Hitam", "Manual", 2021);
        Console.WriteLine("Merk             : " + honda.merk);
        Console.WriteLine("Warna            : " + honda.warna);
        Console.WriteLine("Tipe transmisi   : " + honda.tipeTransimi);
        Console.WriteLine("Tahun keluar     : " + honda.tahun);
        Console.WriteLine();

        mobilSedan toyota = new mobilSedan("Toyota Vios", "Putih", "Matic", 2023);
        Console.WriteLine("Merk             : " + toyota.merk);
        Console.WriteLine("Warna            : " + toyota.warna);
        Console.WriteLine("Tipe transmisi   : " + toyota.tipeTransimi);
        Console.WriteLine("Tahun keluar     : " + toyota.tahun);
        Console.WriteLine();

        // IKAN
        Ikan mas = new Ikan("Ikan Mas", "Merah", "Danau", "Air tawar", "Bertelur", 7);
        Console.WriteLine("Nama             : " + mas.nama);
        Console.WriteLine("Habitat          : " + mas.habitat);
        Console.WriteLine("Jenis perairan   : " + mas.jenisPerairan);
        Console.WriteLine("Cara reproduksi  : " + mas.reproduksi);
        Console.WriteLine("Jumlah sirip     : " + mas.jumlahSirip);
        Console.WriteLine();

        Ikan paus = new Ikan("Ikan Paus", "Hitam", "Laut", "Air laut", "Melahirkan", 10);
        Console.WriteLine("Nama             : " + paus.nama);
        Console.WriteLine("Habitat          : " + paus.habitat);
        Console.WriteLine("Jenis perairan   : " + paus.jenisPerairan);
        Console.WriteLine("Cara reproduksi  : " + paus.reproduksi);
        Console.WriteLine("Jumlah sirip     : " + paus.jumlahSirip);
        Console.WriteLine();

        // BURUNG
        Burung elang = new Burung("Elang", "Hutan", "Karnivora", "soliter");
        Console.WriteLine("Nama             : " + elang.nama);
        Console.WriteLine("Habitat          : " + elang.habitat);
        Console.WriteLine("Jenis makanan    : " + elang.jenisMakanan);
        Console.WriteLine("Perilaku         : " + elang.perilaku);
        Console.WriteLine();

        Burung merak = new Burung("Merak", "Hutan", "Omnivora", "Berkelompok");
        Console.WriteLine("Nama             : " + merak.nama);
        Console.WriteLine("Habitat          : " + merak.habitat);
        Console.WriteLine("Jenis makanan    : " + merak.jenisMakanan);
        Console.WriteLine("Perilaku         : " + merak.perilaku);
        Console.WriteLine();

        // KOMPUTER
        Komputer asus = new Komputer("Asus", "Intel i9-13900HX", "RTX 3080 Ti", 16, 512);
         Console.WriteLine("Merk             : " + asus.merk);
         Console.WriteLine("Prosesor         : " + asus.prosesor);
         Console.WriteLine("GPU              : " + asus.gpu);
         Console.WriteLine("RAM              : " + asus.ram + "GB");
         Console.WriteLine("SSD              : " + asus.ssd + "GB");
         Console.WriteLine();

         Komputer acer = new Komputer("Acer", "AMD Ryzen 5 5600H", "AMD Radeon Vega 7", 8, 256);
         Console.WriteLine("Merk             : " + acer.merk);
         Console.WriteLine("Prosesor         : " + acer.prosesor);
         Console.WriteLine("GPU              : " + acer.gpu);
         Console.WriteLine("RAM              : " + acer.ram + "GB");
         Console.WriteLine("SSD              : " + acer.ssd + "GB");
    }   
}
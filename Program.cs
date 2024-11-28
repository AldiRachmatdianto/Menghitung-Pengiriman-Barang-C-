// class Calculator
// {
//     public static void Main(string[] args) {

//         int beratBarang, biaya;
//         string hitung;
            
//         Console.Write("Apakah anda ingin menghitung biaya pengiriman suatu barang (y/n)?  ");
//         hitung = Console.ReadLine();

//         if (hitung == "y" )
//         {
//         Console.Write("Masukkan berat barang berupa Kilogram: ");
//         beratBarang = Convert.ToInt32(Console.ReadLine());
//         if (beratBarang > 0)
//         {
            
//         } else {
//             Console.WriteLine("Error");
//         }
//         }
//         else if (hitung == "n") {
//             Console.Write("Terima Kasih");
//         } else {
//         Console.Write("Tolong Jawab Yang Benar");

//         }





//             }





            
//     }

using System;

class Program
{
    static void Main()
    {
        // Variabel untuk konfirmasi
        string input;
        bool hitung = Konfirmasi("Mau menghitung biaya pengiriman?");

        if (hitung)
        {
            while (hitung)
            {
                
            
            Console.Write("Masukkan Berat Barang Berupa Kilogram: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out int beratBarang) && beratBarang > 0)
            {
                int biaya = BiayaPengiriman(beratBarang);
                Console.WriteLine($"Total biaya dari {beratBarang} Kg adalah {biaya} Rupiah");
            }
            else
            {
                Console.WriteLine("Tidak boleh kurang dari 0 kg");
            }

            hitung = Konfirmasi("Mau menghitung lagi?");
         else if (hitung == false) {
            Console.WriteLine("tolong masukkan angka yang benar");
        }
            }


        Console.WriteLine("Terima kasih");
    }

    static int BiayaPengiriman(int weight)
    {
        int totalBiaya;

        if (weight == 1)
        {
            totalBiaya = 10000;
        }
        else if (weight <= 5)
        {
            totalBiaya = 7500 + BiayaPengiriman(weight - 1);
        }
        else
        {
            totalBiaya = 5000 + BiayaPengiriman(weight - 1);
        }

        return totalBiaya;
    }

    static bool Konfirmasi(string message)
    {
        Console.WriteLine($"{message} (y/n)");
        string response = Console.ReadLine().ToLower();

        return response == "y";
    }
}

System.Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
int sayi = int.Parse(System.Console.ReadLine());

for (int i = 0; i < sayi; i++)
{
    System.Console.WriteLine("Sayı giriniz: ");
    int sayi2 = int.Parse(System.Console.ReadLine());
    if (sayi2 % 2 == 0)
    {
        System.Console.WriteLine(sayi2 + " sayısı çifttir.");
    }
}
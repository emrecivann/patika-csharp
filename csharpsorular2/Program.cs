System.Console.WriteLine("Lütfen iki adet pozitif sayı giriniz.");
int n = int.Parse(System.Console.ReadLine());
int m = int.Parse(System.Console.ReadLine());

for (int i = 0; i < n; i++)
{
    System.Console.Write("Pozitif sayı giriniz: ");
    int sayi = int.Parse(System.Console.ReadLine());
    if (sayi % m == 0)
        System.Console.WriteLine(sayi);
}
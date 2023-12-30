System.Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
int n = int.Parse(System.Console.ReadLine());
string[] kelimeler = new string[n];

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("Lütfen bir kelime giriniz");
    kelimeler[i] = System.Console.ReadLine();
}

for (int i = --n; i >= 0; i--)
{
    System.Console.WriteLine(kelimeler[i]);
}

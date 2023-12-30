System.Console.WriteLine("Lütfen bir cümle giriniz: ");
string cumle = System.Console.ReadLine();

string[] kelimeler;
kelimeler = cumle.Split(' ');

int kelimeSayisi = kelimeler.Length;

int harfSayisi = cumle.Replace(" ", "").Length;

System.Console.WriteLine($"Cumledeki kelime sayisi: {kelimeSayisi}, harf sayisi: {harfSayisi}");
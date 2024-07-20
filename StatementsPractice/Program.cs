Console.Write("Lütfen bir sayı giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());
// Kullanıcıdan alınan sayı için 10 ile ilişkili kontrollerinin sağlanması
if (a<10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else if (a>10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}
// Kullanıcıdan alınan sayı için çift veya tek olma durumunun incelenmesi
if (a % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}
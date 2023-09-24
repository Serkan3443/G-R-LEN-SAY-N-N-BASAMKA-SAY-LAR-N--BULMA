namespace c__sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz:");
            decimal sayi = Convert.ToDecimal(Console.ReadLine());

            int sayac = 0;
            for (decimal i=sayi; sayi>=10; i--)
            {
                sayi /=10;
                sayac++;
                if (sayi < 10)
                    break;

            }
            sayac++;
            Console.WriteLine("Bu sayı basamak sayısı.:" + sayac);

            while (sayi>=10)
            {
                sayi /=10;
                sayi--;
                sayac++;
                if (sayi < 10)
                    break;
            }
            Console.WriteLine("While ile basamak sayısı: " + sayac);
            Console.Read();
        }
    }
}
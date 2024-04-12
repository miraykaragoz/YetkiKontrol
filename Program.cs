namespace YetkiKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yetki kontrol programına hoşgeldiniz. Devam etmek için lütfen enter'a basınız.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Kullanıcı adı oluşturunuz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Şifre oluşturunuz: ");
            string sifre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Kullanıcı adınızı giriniz: ");
            string girisKullanici = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz: ");
            string girisSifre = Console.ReadLine();

            if (kullaniciAdi == girisKullanici && sifre == girisSifre)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı veya şifre");
            }
        }
    }
}

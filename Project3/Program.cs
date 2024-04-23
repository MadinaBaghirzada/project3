namespace Project3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("maashinizi qeyd edin");
        int maash = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Istediyiniz bonusu qeyd edin");
        int bonus = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Pul(maash, bonus));
    }

    static int Pul(int a, int b)
    {
        return a + (a * b / 100);
    }
}


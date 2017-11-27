namespace ProjectEuler_Problem_3
{
    class Program
    {
        static void Main()
        {

            long s2;
            s2 = 600851475143;
            System.Console.Write("-----Doğruluk Kontrol-----");
            System.Console.WriteLine();
            for (int i = 2; i < s2; ++i)
            {
                if (s2 % i == 0)
                {
                    System.Console.Write(i + " / " + s2 + " = ");
                    s2 = s2 / i;
                    System.Console.Write(s2);
                    System.Console.WriteLine();
                    i = 2;
                }
            }

            System.Console.Write("-----Cevap-----");
            System.Console.WriteLine();
            System.Console.Write(s2);
            System.Console.WriteLine();
        }
    }
}


internal class Program
{
    static void ggg()
    {
        while (true)
        {
            Console.WriteLine("Введите число: ");
            string b2 = Console.ReadLine().ToLower();
            if (b2 == "exit")
            {
                break;
            }
            int b1 = Convert.ToInt32(b2);
            int factorio = 1;
            if(b1<0)
            {
                factorio = -1;
                b1 *= -1;
            }
            for (int i = 1; i <= b1; i++)
            {
                if (b1 % i == 0) // % - Деление нацело 
                {
                    Console.Write(i*factorio);
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
       
    }

    static void gg()
    {
        
        int[,] table = new int[9, 9];
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = (i + 1) * (j + 1);
                if (table[i, j] >= 10)
                {
                    Console.Write(table[i, j] + " ");
                }
                else
                {
                    Console.Write(table[i, j] + "  ");
                }
            }
            Console.WriteLine();
        }
    }
    static void g()
    {

        Random random = new Random();
        int b = random.Next(1, 101);
        string m;
        int m1;
        Console.WriteLine("Угадай число от 1 до 100: ");
        do
        {

            m = Console.ReadLine();
            m1 = Convert.ToInt32(m);
            if (m1 < b)
            {
                Console.WriteLine("Больше");
            }
            if (m1 > b)
            {
                Console.WriteLine("Меньше");
            }
        }
        while (m1 != b);
        Console.WriteLine("Ура,победа");
    }
    private static void Main()
    {
        {
           
            string a;
            int a1;
            do
            {
                Console.WriteLine("1.Угадай чурку");
                Console.WriteLine("2.Таблица умножения");
                Console.WriteLine("3.Делители числа");
                Console.WriteLine("4.Закрыть");
                Console.Write("Ввод:");
                a = Console.ReadLine();
                a1 = Convert.ToInt32(a);
                if (a1 == 1)
                {
                    g();
                }
                else if (a1 == 2)
                {
                    gg();
                }
                else if (a1 == 3)
                {
                    ggg();
                }
                else
                    Console.WriteLine("Мы программисты, а не тостеры");
             }
            while (a1 != 4);
            Console.WriteLine("Конец программы");

        }
    }
}


            
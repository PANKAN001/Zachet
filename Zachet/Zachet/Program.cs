int Vibor = 0;
while(Vibor != 4)
{
    Console.WriteLine("\nВыберете:\n1 - Шифр Цезаря\n2 - Переворот части строки\n3 - Образование в Древнем Риме\n4 - Закрыть программу");
    Vibor = Convert.ToInt32(Console.ReadLine());
    if (Vibor == 1)
    {
        int Otv_1 = 0;
        while (Otv_1 != 2)
        {
            string[] Alf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            Console.Write("\nВведите слово: ");
            string word = Console.ReadLine();
            Console.Write("Введите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            if (K > 26)
            {
                int Schet = 0;
                while (K > 26)
                {
                    K = K - 26;
                    Schet++;
                }
            }
            foreach (char c in word)
            {
                for (int i = 0; i < Alf.Length; i++)
                {
                    if (Convert.ToString(c) == Alf[i])
                    {
                        try
                        {
                            Console.Write(Alf[i - K]);
                        }
                        catch
                        {
                            Console.Write(Alf[26 + (i - K)]);
                        }
                    }
                }
            }
            Console.WriteLine("\nПродолжить?\n1 - Да\n2 - Нет");
            Otv_1 = Convert.ToInt32(Console.ReadLine());
        }
    }
    if (Vibor == 2)
    {
        int Otv_1 = 0;
        while (Otv_1 != 2)
        {
            string str = "qq";
            while (true)
            {
                Console.Write("\nВведите строку(менее 1000 символов): ");
                str = Console.ReadLine();
                if (str.Length < 1000)
                    break;
                Console.WriteLine("Строку меньше 1000 символов!");
            }
            int i = 0;
            while (true)
            {
                Console.Write("Введите число i: ");
                i = Convert.ToInt32(Console.ReadLine());
                if ((i - 1) < str.Length)
                    break;
                Console.WriteLine("Число не может быть больше строки!");
            }
            int j = 0;
            while (true)
            {
                Console.Write("Введите число j: ");
                j = Convert.ToInt32(Console.ReadLine());
                if ((j - 1) < str.Length)
                    break;
                Console.WriteLine("Число не может быть больше строки!");
            }
            char[] Mass = str.ToCharArray();
            char st = Mass[i - 1];
            Mass[i - 1] = Mass[j - 1];
            Mass[j - 1] = st;
            foreach (char c in Mass)
            {
                Console.Write(c);
            }
            Console.WriteLine("\nПродолжить?\n1 - Да\n2 - Нет");
            Otv_1 = Convert.ToInt32(Console.ReadLine());
        }
    }
    if (Vibor == 3)
    {
        Console.Write("\nВведите x (Начальная поледовательность): ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите n (Ряд до каторого дойти): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int KolVo = 0;
        int Schet = 0;

        int Vse = 0;
        while (Vse != n)
        {
            char[] Mass = Convert.ToString(x).ToCharArray();
            for (int i = KolVo; i < Mass.Length; i++)
            {
                int ElMas = Mass[KolVo];
                if (ElMas == Mass[i])
                {
                    Schet++;
                }
                else
                {
                    Console.Write(Schet);
                    Console.Write(Mass[KolVo]);
                    KolVo += Schet;
                    Schet = 0;
                    break;
                }
            }
            Vse++;
        }
    }
}
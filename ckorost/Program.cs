using ckorost;


namespace lol
{
    class Pragram
    {
        static void Main(string[] args)
        {
            int a = 2;
            do
            {
                int[] pos;
                Thread tim = new Thread(_ =>
                {
                    int time = 60;
                    while (time > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine(time);
                        time = time - 1;
                        Thread.Sleep(1000);
                    }
                    while (time > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 10); Console.WriteLine(0);
                        Console.SetCursorPosition(1, 10);
                        time = time - 1;
                        Console.WriteLine(time);
                        Thread.Sleep(1000);
                    }
                    Console.Clear();
                    Console.WriteLine("Ваше время закончилось нажмите любую клавишу для показа результатов");
                });

                Tablica player = new Tablica();
                Console.WriteLine("Введите имя для таблицы рекордов");
                player.Name = Console.ReadLine();
                Console.Clear();
                while (a > 1)
                {
                    Console.WriteLine("Глядя на левую сторону дороги и сам того не зная, не узнавая его, любовался тем дубом, которого он искал.");
                    Console.WriteLine("Старый дуб, весь преображенный, раскинувшись шатром сочной, темной зелени, млел, чуть колыхаясь в лучах ");
                    Console.WriteLine("вечернего солнца. Ни корявых пальцев, ни болячек, ни старого недоверия и горя, – ничего не было видно.");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Когда будете готовы нажмите Enter");
                    Console.ReadLine();
                    tim.Start();
                    Tekst tekst = new Tekst();
                    pos = tekst.text();
                    int lol = pos[1];
                    int hi = pos[2];

                    player.symbsec = pos[1] / pos[2];
                    player.symbmin = player.symbsec * 60 / 1;
                    Console.WriteLine("Введите число");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ваши результаты:");
                Console.Write(player.Name);
                Console.Write("   символы в минуту" + player.symbmin);
                Console.Write("   символы в секунду" + player.symbsec);
                Console.WriteLine("хотите перепройти тест?");
                Console.WriteLine("1 Да");
                Console.WriteLine("2 Нет");
            }while (a > 1);
        }
    }
}
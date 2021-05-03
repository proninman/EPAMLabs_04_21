using System;

namespace AT_Lab2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
{

                // Создаем массивы имен для антагонистов
                string[] skel = { "Череп", "Кость", "Скелет", "Остов", "Костяк", "Худой", "Мощи" };
                string[] zomb = { "Плоть", "Гниль", "Мясо", "Нежиль", "Живой труп", "Нежить", "Нелюдь" };
                string[] lic = { "Магик", "Колдун", "Некромант" };
                // Заполняем параметры персонажа игрока- Количество жизней, атаку и защиту.
                Random rnd1 = new Random(99);
                int hr_rnd2 = rnd1.Next(33, 66);
                int hr_rnd3 = rnd1.Next(33, 66);
                int hr_rnd4 = rnd1.Next(33, 66);


                Hero hero = new Hero("Избранный", hr_rnd2, hr_rnd3, hr_rnd4);
                hero.GetInfo();
                // Выбираем противника. Параметры противника генерируются случайным образом, но в соответствии с видом антагониста.
                Console.WriteLine("Выберите  умертвия для поединка");
                Console.WriteLine("1-Скелет. Сбалансирован, сочетает средние значения очков жизней, атаки и защиты");
                Console.WriteLine("2-Зомби. Обладает внушительным здоровьем, слабой атакой и средней защитой");
                Console.WriteLine("3-Лич. Обладает средним здоровьем, сильной атакой и слабой защитой");
                int n = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int i = 0;
                switch (n)
                {
                    case 1:
                        int sk_rnd1 = rnd.Next(0, 6);
                        int sk_rnd2 = rnd.Next(33, 66);
                        int sk_rnd3 = rnd.Next(33, 66);
                        int sk_rnd4 = rnd.Next(33, 66);

                        Skeleton skeleton = new Skeleton(skel[sk_rnd1], sk_rnd2, sk_rnd3, sk_rnd4);
                        skeleton.GetInfo();

                        // Бой. Каждый ход стороны обмениваются ударами, при этом сила удара считается как случайное число ,
                        // от 1 до 100, умноженное на атаку персонажа, а защита- как случайное число от 1 до 100 , умноженное
                        // на защиту персонажа. Если атака больше защиты, то персонаж получает урон в количестве 1 пункта здоровья.
                        // Бой продолжается, пока пункты здоровья одного из персонажей не снизятся до 0, в этом случае он объявляется
                        // проигравшим.

                        while (sk_rnd2 > 0 & hr_rnd2 > 0)
                        {
                            i = i + 1;
                            int fight_rnd = rnd.Next(0, 100);
                            int fight_rnd1 = rnd1.Next(0, 100);

                            if (fight_rnd * hr_rnd3 >= fight_rnd1 * sk_rnd4)
                            {
                                sk_rnd2 = sk_rnd2 - 1;
                            }
                            if (fight_rnd * sk_rnd3 >= fight_rnd1 * hr_rnd4)
                            {
                                hr_rnd2 = hr_rnd2 - 1;
                            }
                        }
                        // Пользователь получает информацию о победившем персонаже и девиз победителя.
                        if (hr_rnd2 == 0)
                        {
                            Console.WriteLine($"Избранный погиб, уничтоженный скелетом по имени {skel[sk_rnd1]} на {i} ходу");
                            Skeleton.Motto();
                        }
                        else

                        {
                            Console.WriteLine($"Избранный победил и  уничтожил скелет по имени {skel[sk_rnd1]} на {i} ходу");
                            Hero.Motto();
                        }

                        break;
                    case 2:
                        int zb_rnd1 = rnd.Next(0, 6);
                        int zb_rnd2 = rnd.Next(66, 100);
                        int zb_rnd3 = rnd.Next(1, 33);
                        int zb_rnd4 = rnd.Next(33, 66);
                        Zomby zomby = new Zomby(zomb[zb_rnd1], zb_rnd2, zb_rnd3, zb_rnd4);
                        zomby.GetInfo();

                       
                       while (zb_rnd2 > 0 & hr_rnd2 > 0)
                        {
                            i = i + 1;
                            int fight_rnd = rnd.Next(0, 100);
                            int fight_rnd1 = rnd1.Next(0, 100);
                            if (fight_rnd * hr_rnd3 >= fight_rnd1 * zb_rnd4)
                            {
                                zb_rnd2 = zb_rnd2 - 1;
                            }
                            if (fight_rnd * zb_rnd3 >= fight_rnd1 * hr_rnd4)
                            {
                                hr_rnd2 = hr_rnd2 - 1;
                            }
                        }
                        if (hr_rnd2 == 0)
                        {
                            Console.WriteLine($"Избранный погиб, уничтоженный зомби по имени {zomb[zb_rnd1]} на {i} ходу");
                            Zomby.Motto();
                        }
                        else

                        {
                            Console.WriteLine($"Избранный победил и  уничтожил зомби {zomb[zb_rnd1]} на {i} ходу");
                            Hero.Motto();
                        }


                        break;
                    case 3:
                        int li_rnd1 = rnd.Next(0, 2);
                        int li_rnd2 = rnd.Next(33, 66);
                        int li_rnd3 = rnd.Next(66, 100);
                        int li_rnd4 = rnd.Next(1, 33);
                        Lich lich = new Lich(lic[li_rnd1], li_rnd2, li_rnd3, li_rnd4);
                        lich.GetInfo();

                        while (li_rnd2 > 0 & hr_rnd2 > 0)
                        {
                            i = i + 1;
                            int fight_rnd = rnd.Next(0, 100);
                            int fight_rnd1 = rnd1.Next(0, 100);

                            if (fight_rnd * hr_rnd3 >= fight_rnd1 * li_rnd4)
                            {
                                li_rnd2 = li_rnd2 - 1;
                            }
                            if (fight_rnd * li_rnd3 >= fight_rnd1 * hr_rnd4)
                            {
                                hr_rnd2 = hr_rnd2 - 1;
                            }
                        }
                        if (hr_rnd2 == 0)
                        {
                            Console.WriteLine($"Избранный погиб, уничтоженный личем по имени {lic[li_rnd1]} на {i} ходу");
                            Lich.Motto();
                        }
                        else

                        {
                            Console.WriteLine($"Избранный победил и  уничтожил лича по имени {lic[li_rnd1]} на {i} ходу");
                            Hero.Motto();
                        }


                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную цифру");
                        break;
                }





            }
        }
    }
}

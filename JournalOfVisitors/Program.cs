using System;
using System.IO;
using System.Collections.Generic;

namespace JournalOfVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Новая папка\Visitors.txt";
            List<Visitor> visitors = new List<Visitor>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1.Внести посетителя");
                Console.WriteLine("2.Отметить уход");
                Console.WriteLine("3.Просмотр всех посетителей");
                Console.WriteLine("4.Выход");
                int.TryParse(Console.ReadLine(), out int menu);
                switch (menu)
                {
                    case 1:
                        int order=0;
                        Console.Clear();
                        Console.WriteLine("Введите ИИН и ФИО посетителя: ");
                        visitors.Add(new Visitor() { ID = Console.ReadLine(),
                            FullName = Console.ReadLine(),EnterTime = DateTime.Now });
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                       // Console.WriteLine("Выберите номер посетителя: ");
                        //int.TryParse(Console.ReadLine(), out int order_);
                        Console.WriteLine("Введите время ухода(dd.mm.yyyy hh:mm): ");
                        visitors.Add(new Visitor()
                        {
                            ExitTime = DateTime.Parse(Console.ReadLine())
                        });
                        Console.ReadLine();
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("{0,2}{1,15}{2,30}{3,40}", "ИИН ", "ФИО ", 
                            "Время прихода", "Время ухода ");
                        foreach (var person in visitors)
                        {
                            Console.WriteLine("{0,2}{1,15}{2,30}{3,40}", person.ID, 
                                person.FullName,person.EnterTime,person.ExitTime);
                        };
                        Console.ReadLine();
                        break;


                    case 4:
                        using (var stream = new StreamWriter(path))
                        {
                            stream.Write(visitors);
                        }
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

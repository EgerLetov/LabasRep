using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

public class Program
    {
    public static void Main(string[] args)
        {
        FileWork fwork = new FileWork();
        Eash eash = new Eash(null, null);
        Dur dur = new Dur();

        Console.WriteLine("\nНомер 1-------------------------------------------------------------------");
        ListWork listWork = new ListWork();
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Исходный список: " + string.Join(", ", list));

        listWork.ReverseListRecursive(list, 0, list.Count - 1);

        Console.WriteLine("Перевернутый список: " + string.Join(", ", list));

        Console.WriteLine("\nНомер 2-------------------------------------------------------------------");
        Console.WriteLine("Наш список: " + string.Join(", ", list));
        Console.WriteLine("Какое число хотите вставить?");
        int F = dur.DurInt(Console.ReadLine());
        Console.WriteLine("После и перед каким числом хотите вставить?");
        int E = dur.DurInt(Console.ReadLine());
        listWork.InsLeftRight(list, E, F);
        Console.WriteLine("Список с добавленными элементами: " + string.Join(", ", list));

        Console.WriteLine("\nНомер 3-------------------------------------------------------------------");
        HashSet<string> allDiscos = new HashSet<string> { "ДПС", "Тайное вечере", "Вечеринка PDD", "ФИТовская диско", "MC Удод",
            "Концерт Ивана Золо", "Лекция дифуры" };
        Dictionary<string, HashSet<string>> studentAttendance = new Dictionary<string, HashSet<string>>()
            {
            {"Веснин Егор", new HashSet<string> { "Тайное вечере", "Вечеринка PDD", "ФИТовская диско", "MC Удод", "Концерт Ивана Золо" } },
            {"Торгашинов Андрей", new HashSet<string> { "ДПС", "ФИТовская диско", "MC Удод", "Концерт Ивана Золо" } },
            {"Збинский Александр", new HashSet<string> { "ДПС", "Тайное вечере", "ФИТовская диско" } },
            {"Антон Бордзак", new HashSet<string> { "Тайное вечере", "Вечеринка дяди Пети", "ФИТовская диско" } },
            {"Александров Павел", new HashSet<string> { "ДПС", "ФИТовская диско"} },
            {"Палкина София", new HashSet<string> { "Вечеринка PDD", "ФИТовская диско", "Концерт Ивана Золо" } },
            {"Нишатаев Денис", new HashSet<string> { "Тайное вечере", "Вечеринка PDD", "ФИТовская диско"} },
            {"Пророк Санбой", new HashSet<string> { "Тайное вечере", "Концерт Ивана Золо", "ФИТовская диско" } }
        };

        Eash disco_life = new Eash(allDiscos, studentAttendance);
        disco_life.SomeInfDic();

        Console.WriteLine("\nНомер 4-------------------------------------------------------------------");
        HashSet<char> ch = fwork.HashFileCharChot("C:\\Users\\Gorge_Novak\\source\\repos\\Laba4better\\Laba4better\\play_list.txt");
        foreach (char c in ch.OrderBy(c => c))
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nНомер 5-------------------------------------------------------------------");
        SortedSet<string> sname = new SortedSet<string>();
        Dictionary<string, string[]> Exam = eash.ExamTabe(fwork.FileOneString("C:\\Users\\Gorge_Novak\\source\\repos\\Laba4better\\Laba4better\\class_marks.txt"), ref sname);
        Console.WriteLine();
        Console.WriteLine("Допущенны к экзамену:");
        Console.Write("|");
        Console.Write("{0,25}", $"Фамилия Имя");
        Console.WriteLine("{0,16}", $"| мат рус окр |");
        foreach (string key in sname.ToList())
        {
            if ((Convert.ToInt32(Exam[key][1]) >= 30) && (Convert.ToInt32(Exam[key][2]) >= 30) && (Convert.ToInt32(Exam[key][3]) >= 30))
            {
                if (Convert.ToInt32(Exam[key][1]) + Convert.ToInt32(Exam[key][2]) + Convert.ToInt32(Exam[key][3]) >= 140)
                {
                    Console.Write("|");
                    Console.Write("{0,25}", $"{key} {Exam[key][0]}");
                    Console.WriteLine("{0,16}", $"|  {Exam[key][1]}  {Exam[key][2]}  {Exam[key][3]} |");
                }
            }
        }
    }
    }

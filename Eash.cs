public class Eash
{
    private HashSet<string> Hash { get; set; }
    private Dictionary<string, HashSet<string>> Table { get; set; }

    public Eash(HashSet<string> hash, Dictionary<string, HashSet<string>> table)
    {
        Hash = hash ?? new HashSet<string>();
        Table = table ?? new Dictionary<string, HashSet<string>>();

    }
    public void SomeInfDic()
    {
        HashSet<string> allStudentsDiscos = new HashSet<string>(Hash);

        foreach (var student in Table)
        {
            allStudentsDiscos.IntersectWith(student.Value);
        }

        Console.WriteLine("Посетили все ученики: " + string.Join(", ", allStudentsDiscos));

        HashSet<string> someStudentsDiscos = new HashSet<string>();
        foreach (var student in Table)
        {
            someStudentsDiscos.UnionWith(student.Value);
        }

        Console.WriteLine("Посетил хоть кто-то: " + string.Join(", ", someStudentsDiscos));


        HashSet<string> noStudentsDiscos = new HashSet<string>(Hash);
        noStudentsDiscos.ExceptWith(someStudentsDiscos);

        Console.WriteLine("Не посетил никто: " + string.Join(", ", noStudentsDiscos));



    }
    public Dictionary<string, string[]> ExamTabe(List<string> lst, ref SortedSet<string> surn)
    {
        Dictionary<string, string[]> table = new Dictionary<string, string[]>();
        string[] values = new string[5];
        string[] strs = new string[4];
        for (int i = 1; i < lst.Count; i++)
        {
            values = lst[i].Split(' ');
            strs = new string[4] { values[0], values[2], values[3], values[4] };
            table.Add(values[1], strs);
            surn.Add(values[1]);
        }
        return table;
    }

}
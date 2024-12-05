class Dur()
{
    public int DurInt(String s)
    {
        while (!int.TryParse(s, out int x))
        {
            Console.WriteLine("�� ����� �� ����� �����.");
            Console.WriteLine("������� �����:");
            s = Console.ReadLine();

        }
        return Convert.ToInt32(s);
    }
    public int FileInt(String s)
    {
        if (!int.TryParse(s, out int x))
        {
            Console.WriteLine("������!!! <<" + s +">> - �� �����!");
            return 0;
        }
        else
        {
            return Convert.ToInt32(s);
        }
    }
    public double FileDouble(String s)
    {
        if (!double.TryParse(s, out double x))
        {
            Console.WriteLine("������!!! <<" + s + ">> - �� �����!");
            return 0;
        }
        else
        {
            return Convert.ToDouble(s);
        }
    }
    public double DurDub(String s)
    {
        while (!double.TryParse(s, out double x))
        {
            Console.WriteLine("�� ����� �� �����.");
            Console.WriteLine("������� �����:");
            s = Console.ReadLine();

        }
        return Convert.ToDouble(s);
    }
    public long Durlong(String s)
    {
        while (!long.TryParse(s, out long x))
        {
            Console.WriteLine("�� ����� �� �����.");
            Console.WriteLine("������� �����:");
            s = Console.ReadLine();

        }
        return Convert.ToInt64(s);
    }
    public Char DurChar(String s)
    {
        while (s.Length > 1)
        {
            Console.WriteLine("�������� ������ ��������� ����� ���� ����!");
            Console.WriteLine("������� ������:");
            s = Console.ReadLine();

        }
        return Convert.ToChar(s);
    }
    public Char DurMenu(String s)
    {
        return Convert.ToChar(s[0]);
    }
}
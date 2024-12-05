class FileWork
{
    public HashSet<char> HashFileCharChot(string name)
    {
        LetersWork lwork = new LetersWork();
        HashSet<char> H = new HashSet<char>();
        FileStream f = new FileStream(name, FileMode.Open);
        BinaryReader file = new BinaryReader(f);
        try
        {
            char l;
            int flag=0;
            int waswords = 0;
            Console.WriteLine("Буквы из чётных слов:");
            int[] ban_sim = { ',', '.', '\n', '\t', ' ', '-', '+', '!', '?', '_' };
            for (; file.BaseStream.Position < file.BaseStream.Length;)
            {
                
                l = file.ReadChar();
                foreach (char str in ban_sim)
                {
                    //if(str == l)
                    //{
                    //    //Console.WriteLine("|" + waswords);
                    //}
                    if ((str == l) && (waswords == 1))
                    {
                        waswords = 0;
                        flag += 1;
                        //Console.WriteLine("/"+l);

                    }
                }
                l = lwork.ToLower(l);
                if (char.IsLetter(l))
                {
                    if (flag %2 == 1)
                    {
                        //Console.Write("+" + l);
                        H.Add(l);
                    }
                    waswords=1;


                }
                //else
                //{
                //    Console.Write("-"+l);
                //}
                //Console.WriteLine("("+flag+")");


            }
            f.Close();
            file.Close();
            return H;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            f.Close();
            file.Close();
            return H;
        }
    }

    public List<string> FileOneString(string name)
    {
        List<string> S = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader(name))
            {
                string line;
                Console.WriteLine("Содержимое файла:");
                while ((line = reader.ReadLine()) != null)
                {
                    S.Add(line);
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл '{name}' не найден.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        return S;
    }
    public List<string> FileString(string name)
    {
        List<string> S = new List<string>();
        FileStream f = new FileStream(name, FileMode.Open);
        BinaryReader file = new BinaryReader(f);
        int N = file.ReadInt32();
        string l;
        Console.WriteLine("Содержимое файла:");
        for (int i=0; i<N;i++)
        {
            l = file.ReadString();
            S.Add(l);

        }
        return S;
    }

}
class ListWork()
{
    public void ReverseListRecursive(List<int> list, int left, int right)
    {
        if (left < right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            ReverseListRecursive(list, left + 1, right - 1);
        }
    }
    public void InsLeftRight(List<int> L, int E, int F)
    {
        int index = L.IndexOf(E);

        if (index == -1)
        {
            Console.WriteLine("Ёлемент E не найден");
            return;
        }

        L.Insert(index, F);
        L.Insert(index + 2, F);


    }

}
class LetersWork
{
    public char ToLower(char c)
    {
        if (c >= '�' && c <= '�')
        {
            return (char)(c + 32);
        }
        return c;
    }


}
class LetersWork
{
    public char ToLower(char c)
    {
        if (c >= 'À' && c <= 'ß')
        {
            return (char)(c + 32);
        }
        return c;
    }


}
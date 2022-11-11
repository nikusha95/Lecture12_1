namespace CustomStack;

public static class ListExtension
{
    public static void RemoveOdd(this List<int> lst)
    {
        for (int i = 0; i < lst.Count; i++)
        {
            if (lst[i] % 2 == 0)
            {
                lst.RemoveAt(i);
                i--;
                if (i < 0)
                {
                    i = 0;
                }
            }
        }
    }
}
namespace CustomStack;

public static class StringExtensions
{
    public static string ConvertUpper(this string str)
    {
        return str.ToUpper();
    }

    public static string ConcatStrings(this string str, string newOne)
    {
        return str + newOne;
    }
}
// See https://aka.ms/new-console-template for more information


class Program
{
    public delegate int MyDelagate(int a, int b);

    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Dummy(int x)
    {
        return x;
    }

    private static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static void Main(string[] args)
    {
        MyDelagate del = Add;
        del += Subtract;
        int result = del.Invoke(3, 2);
        Console.WriteLine($"with delegate Invoke {result}");
        Console.WriteLine(del(3, 2));
        Console.WriteLine();

        Console.WriteLine("Invocation List:");
        foreach (var i in del.GetInvocationList())
        {
            Console.WriteLine(i.Method.Name);
            Console.WriteLine(i.Method.IsPublic);
        }

        del = (int a, int b) => a * b;

        var f = (int a, int b, int c) => a * b * c;
        Action<int, int> action = (a, b) =>
        {
            int c = a + b;
            Console.WriteLine(c);
        };

        var r2 = f(3, 5, 2);
        Console.WriteLine(r2);
        Console.WriteLine(del(10, 5));
    }

    //(int a, int b) => a * b;
    public static int Multiplicate(int a, int b)
    {
        return a * b;
    }
}
public class Program
{
    public static int AddFunction(int a, int b)
    {
        return a + b;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine($"Hello, World and {AddFunction(2, 2)}!");
    }
}
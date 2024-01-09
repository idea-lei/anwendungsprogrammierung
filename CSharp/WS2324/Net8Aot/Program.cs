class Program
{
    public static void Main()
    {
        Type.GetType("Program").GetMethod("SayHello").Invoke(null, null);
        Console.ReadLine();
    }

    public static void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}
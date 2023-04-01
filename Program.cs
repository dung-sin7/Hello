namespace Hello;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");

        string yourName = Console.ReadLine();

        Console.WriteLine("Hello: " + yourName);
    }
}

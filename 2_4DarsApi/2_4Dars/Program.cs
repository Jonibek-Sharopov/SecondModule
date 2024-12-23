namespace _2_4Dars;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string");
        var text = Console.ReadLine();
        var res = SubstrText(text);
        Console.WriteLine(res);
    }
    public static string SubstrText(string text)
    {
        return text.Substring(text.Length - 4);
    }
}
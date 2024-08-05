// See https://aka.ms/new-console-template for more information
using AsciidocLibrary;

public class Program
{
    static void Main(string[] args)
    {
        String str = ParserProcess.Process("= dsa\n\n [dsa]");
        
        Console.WriteLine(str);
    }
}
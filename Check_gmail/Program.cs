using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] str;
        string patern = @"[a-z][a-z0-9.-_]{4,53}[a-z]@gmail.com";
        Regex rg = new Regex(patern);
        using (StreamReader tr = File.OpenText("..\\..\\..\\text.txt"))
        {
            str = tr.ReadToEnd().Split("\n");
            tr.Close();
        }
        str[0] = str[0].Remove(str[0].Length - 1, 1);
        foreach (string i in str)
        {
            Console.Write(i);
            Console.Write(" - ");
            Console.WriteLine(rg.IsMatch(i));
        }
    }
}
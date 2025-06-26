using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(AbbrevName("Sam Harris Qui"));
        Console.WriteLine(AbbrevName("Patrick Feenan"));
        Console.WriteLine(AbbrevName("Evan Cole"));
    }
    public static string AbbrevName(string name)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < name.Trim().Length; i++) 
        {
            if(i == 0)
            {
                sb.Append($"{char.ToUpper(name[i])}.");
            }
            else if (name[i] == ' ')
            {
                sb.Append($"{char.ToUpper(name[i+1])}.");
            }
        }
        return sb.ToString().Trim('.');
    }
    public static string AbbrevNameLinq(string name) =>
        string.Join(".",name.Split(' ').Select((x,i) => char.ToUpper(x[0])));
    
}
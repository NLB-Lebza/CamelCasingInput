
using System.Threading.Channels;

public class CamelCasing
{
    public static string BreakCamelCase(string str){

        string results = "";
        for (int i = 0; i < str.Length; i++) 
        {
            if (char.IsUpper(str[i]))
            {
                results += " ";
            }
            results += str[i];
        }


        return results;
}
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input=BreakCamelCase(input);
        Console.WriteLine(input);
       

    }


}




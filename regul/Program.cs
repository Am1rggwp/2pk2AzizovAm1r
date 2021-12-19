using System;
using System.Text.RegularExpressions;
using System.IO;

namespace regul
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1 задание
            Regex a = new Regex(@"\d{2}-\d{2}-\d{2}");
            string text = @"12-34-56";
            string newText = "";
            string temp_str = "";

            MatchCollection matchCollection = a.Matches(text);
            foreach (Match match in matchCollection)
            {
                newText = match.ToString();
                temp_str = newText.Insert(2, "0");
                Console.WriteLine(Regex.Replace(newText, a.ToString(), temp_str));
            }
            
            //№2 задание
            Regex b = new Regex(@"tel[:]?|cat[:]?");
            string strr = @"tel why did you do this to my cat? tel!";
            string newStr = Regex.Replace(strr, b.ToString(), "");
            Console.WriteLine(newStr);

            //№3 задание
            /*Regex c = new Regex(@" (\d{2}\.\d{2}\.\d{2,4}) | (\d{2}(\.|\:)\d{2}) | ([-+]?\d+) | ([-+]?\d+[.,]\d*)");
            string str = " 09.11.2004 произошел сбой на электростанции 10.11.04 сбой был устранен в 06:54 или в 07.10 " +
                        " В это время на улице было 2 или -5" +
                         " я могу сказать это с точностью до 5.16 или -2,94  ";

            string path = @"F:\test.txt";
            FileStream file = new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            MatchCollection matchCollection = c.Matches(str);

            foreach (Match match in matchCollection)
            {
                writer.Write(match.ToString());
            }
            writer.Close();*/

            
            //№ 4 задание
           /* Regex d = new Regex(@"(\d{1,2}/[a-z]+/\d{4}:(\d{2}:){2}\d{2} [+]\d{4})|((\d{1,3}\.){3}\d{1,3})", RegexOptions.IgnoreCase);
            Console.WriteLine(d.ToString());
            
            string path = @"F:\connects.log";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
            MatchCollection matchCollection = d.Matches(text);
            if (matchCollection.Count == 0)
                Console.WriteLine("null");
            foreach(Match match in matchCollection)
            {
                Console.WriteLine(match.ToString());
            }
            reader.Close();*/
            

        }


    }
}

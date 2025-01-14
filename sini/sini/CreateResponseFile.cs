
using sini;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

public static class CreateResponseFile
{
    public static void Create()
    {
       
            // יצירת קובץ חדש
            using (var writer = new StreamWriter("rsp.rsp", true))
            {
                writer.WriteLine("sini");
                writer.WriteLine("bundle");

                // יצירת קובץ Output
                Console.WriteLine("output file name:");
                string oPut = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(oPut))
                {
                    writer.WriteLine("-o");
                    writer.WriteLine(oPut);
                }

                // הסרת שורות ריקות
                Console.WriteLine("remove empty lines? (enter true only if needed)");
                bool rmvL = Convert.ToBoolean(Console.ReadLine());
                if (rmvL)
                {
                    writer.WriteLine("-r");
                }

                // בחירת שפה
                var languages = new[] { "sql", "text", "all" };
                Console.WriteLine("enter expected language (file extension) or 'all':");
                string lang = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lang))
                {
                    if (languages.Contains(lang.ToLower()))
                    {
                        writer.WriteLine("-l");
                        writer.WriteLine(lang);
                    }
                    else
                    {
                        throw new languagexception();
                    }
                }

                // שם מחבר
                Console.WriteLine("enter author name (or leave empty):");
                string atr = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(atr))
                {
                    writer.WriteLine("-a");
                    writer.WriteLine(atr);
                }

                // הערות
                Console.WriteLine("should write relative path? (enter true only if needed):");
                bool nt = Convert.ToBoolean(Console.ReadLine());
                if (nt)
                {
                    writer.WriteLine("-n");
                }

                // מיון
                Console.WriteLine("sort by name? Press 'e' to sort by extension:");
                string sortBy = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(sortBy))
                {
                    writer.WriteLine("-s");
                }
            }
        }
     
 

}



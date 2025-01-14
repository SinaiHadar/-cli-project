
using sini;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

public static class BundleCommandHandler
{

    public static void Execute(FileInfo output, string language, bool note, bool removeEmptyLines, bool sort,string authorName, bool createRsp)
    {
        try
        {
           
            
                if (createRsp)
                {
                    CreateResponseFile.Create();
                    return;
                }

                if (!createRsp && string.IsNullOrWhiteSpace(language))
                {
                    throw new languagexception();
                }

                // סינון קבצים לפי סוג
                string extension = language == "all" ? "*" : language;
                var files = Directory.GetFiles(Directory.GetCurrentDirectory(), $"*.{extension}");

                var sortedFiles = !sort
                    ? files.OrderBy(Path.GetFileName)
                    : files.OrderBy(file => Path.GetExtension(file));

                Console.WriteLine(output.FullName);

                // יצירת הקובץ וכתיבה בעזרת StreamWriter
                using (var writer = new StreamWriter(output.FullName, true)) // false - יצירת קובץ חדש או דריסה
                {
                    // כתיבת שם המחבר
                    if (!string.IsNullOrEmpty(authorName))
                    {
                    if(authorName.StartsWith("-"))
                    {throw new FormatException();
                    }
                        writer.WriteLine($"# {authorName}");
                    }
                    foreach (var file in sortedFiles)
                    {
                        // כתיבת הערות (נתיב יחסי)
                        if (note)
                        {
                            string relativePath = Path.GetRelativePath(Directory.GetCurrentDirectory(), file);
                            writer.WriteLine($"# {relativePath}");
                        }

                        // קריאת השורות מתוך הקובץ הנוכחי בעזרת StreamReader
                        using (var reader = new StreamReader(file))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                // הוספת רק שורות לא ריקות אם `removeEmptyLines` מוגדר ל-true
                                if (!removeEmptyLines || !string.IsNullOrWhiteSpace(line))
                                {
                                    writer.WriteLine(line);
                                }
                            }
                        }
                    }
                }

                Console.WriteLine($"Files bundled successfully into {output.FullName}");
            }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Invalid file name or path: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid input: {ex.Message}");
        }
        catch (languagexception ex)
        {
            Console.WriteLine($"Invalid language: {ex.Message}");
        }

    }
}


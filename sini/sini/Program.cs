
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Invocation;

    //----------------------------------------- BundleCommand ------------------------------------------
//    var BundleCommand = new Command("bundle", "bunlde cli command bunlde a single file");

////----------------------------------------- BundleOutPutOption ------------------------------------------
//var BundleOutPutOption=new Option<FileInfo>("--output", "file output name");
//BundleOutPutOption.AddAlias("-o");
//BundleCommand.AddOption(BundleOutPutOption);

////----------------------------------------- BundleLanguageOption ------------------------------------------
//var BundleLanguageOption = new Option<string>(
//    "--language", "An option that that must be one of the values of a static list.")
//{IsRequired = true   }
//        .FromAmong(
//            "csharp",
//            "fsharp",
//            "vb",
//            "pwsh",
//            "sql",
//            "java",
//            "js",
//            "tfs",
//            "html",
//            "txt",
//            "xlsx",
//            "python",
//            "all");
//BundleCommand.AddOption(BundleLanguageOption);
//BundleLanguageOption.AddAlias("-l");

////----------------------------------------- BundleNoteOption ------------------------------------------

//var BundleNoteOption = new Option<bool>("--note", "add comment on header file");
//BundleCommand.AddOption(BundleNoteOption);
//BundleNoteOption.AddAlias("-n");
////----------------------------------------- BundleRmvEmptyOption ------------------------------------------

//var BundleRmvEmptyOption = new Option<bool>("--rmv", "remove empty lines");
//BundleCommand.AddOption(BundleRmvEmptyOption);
//BundleRmvEmptyOption.AddAlias("-r");

////----------------------------------------- BundleAuthorOption ------------------------------------------

//var BundleAuthorOption = new Option<string>("--ath", "add author name");
//BundleCommand.AddOption(BundleAuthorOption);
//BundleAuthorOption.AddAlias("-a");
////----------------------------------------- BundleDescendingOption ------------------------------------------
//var BundleSortOption = new Option<bool>(
//            "--sort", "Sort files in ascending order");
//BundleCommand.AddOption(BundleSortOption);
//BundleSortOption.AddAlias("-s");
//var folderArgument = new Argument<string>(
//           "folder",
//           description: "Path to the folder containing files to sort");

//BundleDescendingOption.AddArgument(folderArgument);


//var descendingOption = new Option<bool>(
//           new[] { "--descending", "-d" },
//           description: "Sort files in descending order");

//rootCommand.AddOption(descendingOption);

//var endpointOption = new Option<Uri>("--endpoint") { IsRequired = true };
//----------------------------------------- BundleNoteOption ------------------------------------------

//////////var responseFileOption = new Option<bool>("--rspns", "creates a reponse file");
//////////BundleCommand.AddOption(responseFileOption);
//////////responseFileOption.AddAlias("-f");

//BundleCommand.SetHandler((output, language, note, sort,rmv,ath) =>
//{
//    try
//    {
        //var authorName = "hadari";
        //string extension = language.Equals("all") ? "*" : language;

     
        //    var files = Directory.GetFiles(Directory.GetCurrentDirectory(), $"*.{extension}");

        //var sortedFiles = !sort
        // ? files.OrderBy(Path.GetFileName)
        // : files.OrderBy(file => Path.GetExtension(file));

        // File.Create(output.FullName);
        // var folder = Folder.Open("path/to/folder/{i}")
        // הדפסת התוצאה
       // if(ath.Equals(""))
       // File.WriteAllText(output.FullName, authorName);
       //else
       //     File.Create(output.FullName);


       // if (note)
       // { File.AppendText($"{"#"+Path.GetRelativePath(Path.GetFullPath(Directory.GetCurrentDirectory()), Directory.GetCurrentDirectory())}+\'{output.Name}'"); }

       // Console.WriteLine("Sorted files:");
       // foreach (var file in sortedFiles)
       // { 
       //     Console.WriteLine(file);
       //     var lines = File.ReadAllLines(file);
       //     var nonEmptyLines=lines.AsEnumerable();
       //     if (rmv)
       //         // מסננים את השורות הריקות
       //          nonEmptyLines = lines.Where(line => !string.IsNullOrWhiteSpace(line));
       //     // כותבים את השורות הלא ריקות לקובץ חדש
       //     File.AppendAllLines(output.FullName, nonEmptyLines);


       // }
    
   

//Console.WriteLine($"Current directory is {Environment.GetFolderPath(Environment.SpecialFolder())}");

    //    Console.WriteLine("executed");
    //Console.WriteLine(language);
    //Console.WriteLine(note);
        //    var files = Directory.GetCurrentDirectory(files);
      
        //לעשות על זה catch
        // if (!files.Any())


//    }
//    catch (DirectoryNotFoundException ex)
//    {
//        Console.WriteLine("invalid file name or path");
//    }

//}, BundleOutPutOption, BundleLanguageOption, BundleNoteOption, BundleSortOption, BundleRmvEmptyOption, BundleAuthorOption);

//------------------------- RootCommand -------------------------------------
var RootCommand = new RootCommand("this is a root cli oommand");
RootCommand.AddCommand(BundleCommand.CreateBundleCommand());
await RootCommand.InvokeAsync(args);
//





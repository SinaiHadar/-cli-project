using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;
using System.Security.Cryptography;

public static class BundleCommand
{
    public static Command CreateBundleCommand()
    {
        var bundleCommand = new Command("bundle", "Bundle CLI command to bundle files");



        var outputOption = new Option<FileInfo>(
            aliases: new[] { "--outputfile", "-o" },
            description: "File output name",
           getDefaultValue: () => new FileInfo("new_file.txt")); 

        var ResponseOption = new Option<bool>(
           aliases: new[] { "--createRsp", "-c" },
           description: "creates a response file");


        var languageOption = new Option<string>(
            aliases: new[] { "--language", "-l" }, 
            description: "Language or file extension" )
            //  { IsRequired = createRsp ? false:true}
            .FromAmong("csharp","fsharp",
                        "vb","pwsh",
                        "sql","java",
                        "js","ts",
                        "html","txt",
                        "xlsx","docx",
                        "python","all");

        var sortOption = new Option<bool>(
          aliases: new[] { "--sort", "-s" },
          description: "Sort files alphabetically");

        var noteOption = new Option<bool>(
            aliases: new[] { "--note", "-n" },
            description:"Add a comment on the file header");

        var removeEmptyOption = new Option<bool>(
            aliases: new[] { "--remove", "-r" },
            description:"Remove empty lines");

        var AuthorOption = new Option<string>(
            aliases: new[] { "--author", "-a" },
            description:"add author name");

        

        bundleCommand.AddOption(outputOption);
        bundleCommand.AddOption(languageOption);
        bundleCommand.AddOption(sortOption);
        bundleCommand.AddOption(noteOption);
        bundleCommand.AddOption(removeEmptyOption);
        bundleCommand.AddOption(AuthorOption);
        bundleCommand.AddOption(ResponseOption);


        bundleCommand.SetHandler(
            (output,language,note,remove,sort,author, createRsp) =>
            {
               
                
                BundleCommandHandler.Execute(output, language, note, remove,sort,author, createRsp);
            },
            outputOption, languageOption, noteOption, removeEmptyOption, sortOption,AuthorOption, ResponseOption
        );

        return bundleCommand;
    }
}


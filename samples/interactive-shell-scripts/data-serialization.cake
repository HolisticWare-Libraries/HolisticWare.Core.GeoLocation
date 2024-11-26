using Spectre.Console;

FilePathCollection files;

readonly string line_hash    = new string('#', 120);
readonly string line_equal   = new string('=', 120);
readonly string line_dash    = new string('-', 120);
readonly string line_dot     = new string('.', 120);

int exit_code = -666;

files = GetFiles("../../data/**/*.xsd");
foreach(FilePath file in files)
{
    AnsiConsole.MarkupLine($"{line_hash}");
    AnsiConsole.MarkupLine($"[bold aqua] XML Sxhema XSD file [/]");
    AnsiConsole.MarkupLine($"       [aqua]{file}[/]");

    try
    {
        string ns_root = "HolisticWare.Core.GeoLocation.Data.Formats";
        string ns = ns_root;

        ns = 
            ns_root 
            + "." +
            "Garmin.TCX.TrainingCenterXML.Generated"
            ;

        string dir_destination = file
                                    .GetDirectory()
                                    .ToString().Replace("schemas", "csharp")
                                    ;
        AnsiConsole.MarkupLine($"           [aqua]{dir_destination}[/]");
        EnsureDirectoryExists(dir_destination);
        EnsureDirectoryExists($"{dir_destination}/xsd/");
        EnsureDirectoryExists($"{dir_destination}/xscgen/");

        exit_code = StartProcess
                        (
                            "xsd",
                            new ProcessSettings
                            {
                                Arguments =
                                    $"{file}"
                                    + " " +
                                    "/classes"
                                    + " " +
                                    $"/namespace:{ns}"
                                    + " " +
                                    "/language:CS"
                                    + " " +
                                    $"/outputdir:{dir_destination}/xsd/"
                            }
                        );                
        AnsiConsole.MarkupLine($"{line_dot}");
        exit_code = StartProcess
                        (
                            // dotnet tool
                            // https://github.com/mganss/XmlSchemaClassGenerator
                            "xscgen",
                            new ProcessSettings
                            {
                                Arguments =
                                    "--verbose"
                                    + " " +
                                    $"--namespace={ns}"
                                    + " " +
                                    $"--output={dir_destination}/dotnet-xscgen/"
                                    + " " +
                                    $"{file}"
                            }
                        );                
    }
    catch
    {
        Error ("Build/Run failed File: {0}", file);
    }
}

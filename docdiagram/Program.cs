using System.CommandLine;
using System.Text;
using Ietf.Datatracker.Models;

namespace scl;

class Program
{
    static DatatrackerService _service = new DatatrackerService();

    static async Task<int> Main(string[] args)
    {
        var docIdOption = new Option<string>(
            name: "-d",
            description: "An identifer for the IETF document");

        var rootCommand = new RootCommand("Generate diagrams for IETF documents");
        rootCommand.AddOption(docIdOption);

        rootCommand.SetHandler(async (string docId) => 
            { 
                await GenerateDiagramAsync(docId); 
            },
            docIdOption);

        return await rootCommand.InvokeAsync(args);
    }

    static async Task GenerateDiagramAsync(string docId)
    {
        var docModel = await _service.GetDocumentAsync(docId);
        var diagram = new Diagram(docModel);
        Console.WriteLine(diagram.ToString());
    }

}

internal class Diagram
{
    private object docModel;
    private List<string> relationships=new List<string>();

    public Diagram(Document docModel)
    {
        this.docModel = docModel;
        AddRelationship(docModel.Title, "test");
    }

    private void AddRelationship(string from, string to)
    {
        relationships.Add($"{from} --> {to}");
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("graph LR");
        foreach (var rel in relationships)
        {
            sb.AppendLine(rel);
        }
        return sb.ToString();
    }
}
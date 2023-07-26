using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
// using OpenTelemetry;
// using OpenTelemetry.Trace;

using Ietf.Datatracker;
using Ietf.Datatracker.Models;

// create TodoService as a wrapper for TodoClient
public class DatatrackerService
{
    private readonly IetfDatatrackerClient _client;

    public DatatrackerService()
    {
        var authenticationProvider = new AnonymousAuthenticationProvider();
        var requestAdapter = new HttpClientRequestAdapter(authenticationProvider);
        _client = new IetfDatatrackerClient(requestAdapter);
    }

    // // Example: Get object from api 
    // public async Task<object> GetObjectAsync(string id)
    // {
    //     // get TodoTask from api
    //     var anObject = await _client.Objects[id].GetAsync();
    //     return anObject;
    // }

    // Get Document from api
    public async Task<Document> GetDocumentAsync(string id)
    {
        // get TodoTask from api
        var aDocument = await _client.Api.V1.Doc.Document[id].GetAsync();
        return aDocument;
    }
    
    // Get the documents that have the same name as the one passed in
    // and retreive the states that this document has been in
    // order the documents by rev and return a list of the document its rev and the corresponding states
    public async Task<List<(string, string, string)>> GetDocumentStatesAsync(string name)
    {
        var document = await _client.Api.V1.Doc.Document[name].GetAsync();
        
        var documentHistory = await _client.Api.V1.Doc.Dochistory.GetAsync(req => {
            req.QueryParameters.Doc = document.Id;
        });

        
        var documentStates = new List<(string, string, string)>();
        foreach (var docHistory in documentHistory.Objects)
        {
            foreach (var state in docHistory.Status)
            {
                documentStates.Add((document.Name, document.Rev, state));
            }
        }
        return documentStates;
    }

    // public TracerProvider CreateTelemetryProvider() {
    //     return Sdk.CreateTracerProviderBuilder()
    //         .AddSource("Microsoft.Kiota.Http.HttpClientLibrary")
    //         .AddSource("System.Net.Http")
    //         .AddSource("DatatrackerService")
    //         .AddZipkinExporter(o =>
    //         {
    //             o.Endpoint = new Uri("http://localhost:9411/api/v2/spans");
    //         })
    //         .Build();
    // }


}

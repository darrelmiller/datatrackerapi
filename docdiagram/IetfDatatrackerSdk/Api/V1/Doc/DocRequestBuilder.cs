using Ietf.Datatracker.Api.V1.Doc.Dochistory;
using Ietf.Datatracker.Api.V1.Doc.Document;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Ietf.Datatracker.Api.V1.Doc {
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\doc
    /// </summary>
    public class DocRequestBuilder : BaseRequestBuilder {
        /// <summary>The dochistory property</summary>
        public DochistoryRequestBuilder Dochistory { get =>
            new DochistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The document property</summary>
        public DocumentRequestBuilder Document { get =>
            new DocumentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DocRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/doc", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DocRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/doc", rawUrl) {
        }
    }
}

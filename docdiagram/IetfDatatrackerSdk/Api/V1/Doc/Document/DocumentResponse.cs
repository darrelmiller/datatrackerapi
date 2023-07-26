using Ietf.Datatracker.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Ietf.Datatracker.Api.V1.Doc.Document {
    public class DocumentResponse : IParsable {
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Ietf.Datatracker.Models.Meta? Meta { get; set; }
#nullable restore
#else
        public Ietf.Datatracker.Models.Meta Meta { get; set; }
#endif
        /// <summary>The objects property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Ietf.Datatracker.Models.Document>? Objects { get; set; }
#nullable restore
#else
        public List<Ietf.Datatracker.Models.Document> Objects { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DocumentResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"meta", n => { Meta = n.GetObjectValue<Ietf.Datatracker.Models.Meta>(Ietf.Datatracker.Models.Meta.CreateFromDiscriminatorValue); } },
                {"objects", n => { Objects = n.GetCollectionOfObjectValues<Ietf.Datatracker.Models.Document>(Ietf.Datatracker.Models.Document.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Ietf.Datatracker.Models.Meta>("meta", Meta);
            writer.WriteCollectionOfObjectValues<Ietf.Datatracker.Models.Document>("objects", Objects);
        }
    }
}

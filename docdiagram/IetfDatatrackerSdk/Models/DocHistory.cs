using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Ietf.Datatracker.Models {
    public class DocHistory : IParsable {
        /// <summary>The doc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Doc { get; set; }
#nullable restore
#else
        public string Doc { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The resource_uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceUri { get; set; }
#nullable restore
#else
        public string ResourceUri { get; set; }
#endif
        /// <summary>The rev property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rev { get; set; }
#nullable restore
#else
        public string Rev { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Status { get; set; }
#nullable restore
#else
        public List<string> Status { get; set; }
#endif
        /// <summary>The time property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Time { get; set; }
#nullable restore
#else
        public string Time { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DocHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"doc", n => { Doc = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"resource_uri", n => { ResourceUri = n.GetStringValue(); } },
                {"rev", n => { Rev = n.GetStringValue(); } },
                {"status", n => { Status = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"time", n => { Time = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("doc", Doc);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("resource_uri", ResourceUri);
            writer.WriteStringValue("rev", Rev);
            writer.WriteCollectionOfPrimitiveValues<string>("status", Status);
            writer.WriteStringValue("time", Time);
        }
    }
}

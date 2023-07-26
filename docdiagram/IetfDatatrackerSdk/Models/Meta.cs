using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Ietf.Datatracker.Models {
    public class Meta : IParsable {
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The next property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Next { get; set; }
#nullable restore
#else
        public string Next { get; set; }
#endif
        /// <summary>The offset property</summary>
        public int? Offset { get; set; }
        /// <summary>The previous property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Previous { get; set; }
#nullable restore
#else
        public string Previous { get; set; }
#endif
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Meta CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Meta();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"limit", n => { Limit = n.GetIntValue(); } },
                {"next", n => { Next = n.GetStringValue(); } },
                {"offset", n => { Offset = n.GetIntValue(); } },
                {"previous", n => { Previous = n.GetStringValue(); } },
                {"total_count", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("limit", Limit);
            writer.WriteStringValue("next", Next);
            writer.WriteIntValue("offset", Offset);
            writer.WriteStringValue("previous", Previous);
            writer.WriteIntValue("total_count", TotalCount);
        }
    }
}

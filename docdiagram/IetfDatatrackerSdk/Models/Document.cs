using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Ietf.Datatracker.Models {
    public class Document : IParsable {
        /// <summary>The abstract property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Abstract { get; set; }
#nullable restore
#else
        public string Abstract { get; set; }
#endif
        /// <summary>The ad property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ad { get; set; }
#nullable restore
#else
        public string Ad { get; set; }
#endif
        /// <summary>The expires property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expires { get; set; }
#nullable restore
#else
        public string Expires { get; set; }
#endif
        /// <summary>The external_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalUrl { get; set; }
#nullable restore
#else
        public string ExternalUrl { get; set; }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group { get; set; }
#nullable restore
#else
        public string Group { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The intended_std_level property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntendedStdLevel { get; set; }
#nullable restore
#else
        public string IntendedStdLevel { get; set; }
#endif
        /// <summary>The internal_comments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalComments { get; set; }
#nullable restore
#else
        public string InternalComments { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The note property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The notify property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notify { get; set; }
#nullable restore
#else
        public string Notify { get; set; }
#endif
        /// <summary>The pages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pages { get; set; }
#nullable restore
#else
        public string Pages { get; set; }
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
        /// <summary>The rfc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rfc { get; set; }
#nullable restore
#else
        public string Rfc { get; set; }
#endif
        /// <summary>The shepherd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Shepherd { get; set; }
#nullable restore
#else
        public string Shepherd { get; set; }
#endif
        /// <summary>The states property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? States { get; set; }
#nullable restore
#else
        public List<string> States { get; set; }
#endif
        /// <summary>The std_level property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StdLevel { get; set; }
#nullable restore
#else
        public string StdLevel { get; set; }
#endif
        /// <summary>The stream property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Stream { get; set; }
#nullable restore
#else
        public string Stream { get; set; }
#endif
        /// <summary>The submissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Submissions { get; set; }
#nullable restore
#else
        public List<string> Submissions { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The time property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Time { get; set; }
#nullable restore
#else
        public string Time { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The uploaded_filename property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UploadedFilename { get; set; }
#nullable restore
#else
        public string UploadedFilename { get; set; }
#endif
        /// <summary>The words property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Words { get; set; }
#nullable restore
#else
        public string Words { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Document CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Document();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"abstract", n => { Abstract = n.GetStringValue(); } },
                {"ad", n => { Ad = n.GetStringValue(); } },
                {"expires", n => { Expires = n.GetStringValue(); } },
                {"external_url", n => { ExternalUrl = n.GetStringValue(); } },
                {"group", n => { Group = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"intended_std_level", n => { IntendedStdLevel = n.GetStringValue(); } },
                {"internal_comments", n => { InternalComments = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"notify", n => { Notify = n.GetStringValue(); } },
                {"pages", n => { Pages = n.GetStringValue(); } },
                {"resource_uri", n => { ResourceUri = n.GetStringValue(); } },
                {"rev", n => { Rev = n.GetStringValue(); } },
                {"rfc", n => { Rfc = n.GetStringValue(); } },
                {"shepherd", n => { Shepherd = n.GetStringValue(); } },
                {"states", n => { States = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"std_level", n => { StdLevel = n.GetStringValue(); } },
                {"stream", n => { Stream = n.GetStringValue(); } },
                {"submissions", n => { Submissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"time", n => { Time = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"uploaded_filename", n => { UploadedFilename = n.GetStringValue(); } },
                {"words", n => { Words = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("abstract", Abstract);
            writer.WriteStringValue("ad", Ad);
            writer.WriteStringValue("expires", Expires);
            writer.WriteStringValue("external_url", ExternalUrl);
            writer.WriteStringValue("group", Group);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("intended_std_level", IntendedStdLevel);
            writer.WriteStringValue("internal_comments", InternalComments);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("notify", Notify);
            writer.WriteStringValue("pages", Pages);
            writer.WriteStringValue("resource_uri", ResourceUri);
            writer.WriteStringValue("rev", Rev);
            writer.WriteStringValue("rfc", Rfc);
            writer.WriteStringValue("shepherd", Shepherd);
            writer.WriteCollectionOfPrimitiveValues<string>("states", States);
            writer.WriteStringValue("std_level", StdLevel);
            writer.WriteStringValue("stream", Stream);
            writer.WriteCollectionOfPrimitiveValues<string>("submissions", Submissions);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("time", Time);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("uploaded_filename", UploadedFilename);
            writer.WriteStringValue("words", Words);
        }
    }
}

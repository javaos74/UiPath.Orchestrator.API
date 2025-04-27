using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PTST.UiPath.Orchestrator.Models
{
    public class Release : IUipathResponseSingle
    {
        [JsonPropertyName("Key")]
        public Guid Key { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("OrganizationUnitId")]
        public long OrganizationUnitId { get; set; }

        [JsonPropertyName("OrganizationUnitFullyQualifiedName")]  
        public string OrganizationUnitFullyQualifiedName { get; set; }

        [JsonPropertyName("Arguments")]
        public Argument Arguments { get; set; }

        [JsonPropertyName("Tags")]
        public Tag[] Tags { get; set; }

        [JsonPropertyName("Id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Id { get; set; }
    }
}

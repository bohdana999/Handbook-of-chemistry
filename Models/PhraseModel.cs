using Newtonsoft.Json;

namespace Chemestry.Models
{
    [JsonObject]
    public class PhraseModel
    {
        public PhraseModel()
        {
            Title = string.Empty;
            Description = string.Empty;
        }

        public PhraseModel(string title, string desc)
        {
            Title = title;
            Description = desc;
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
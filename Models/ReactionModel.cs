using Newtonsoft.Json;

namespace Chemestry.Models
{
    [JsonObject]
    public class ReactionModel
    {
        public ReactionModel()
        {
            Title = string.Empty;
            PathToPicture = Constants.DEFAULT_PATH_TO_IMAGE;
        }

        public ReactionModel(string title, string pathToPicture)
        {
            Title = title;
            PathToPicture = pathToPicture;
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("pathToPicture")]
        public string PathToPicture { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Chemestry.Models
{
    [JsonObject]
    public class TableModel
    {
        public TableModel()
        {
            Title = string.Empty;
            PathToPicture = Constants.DEFAULT_PATH_TO_IMAGE;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public TableModel(string title, string pathToPicture, PictureBoxSizeMode sizeMode = PictureBoxSizeMode.StretchImage)
        {
            Title = title;
            PathToPicture = pathToPicture;
            SizeMode = sizeMode;
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("pathToPicture")]
        public string PathToPicture { get; set; }

        [JsonProperty("sizeMode")]
        public PictureBoxSizeMode SizeMode { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
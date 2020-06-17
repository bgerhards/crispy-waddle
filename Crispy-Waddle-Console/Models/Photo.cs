using System;
using Newtonsoft.Json;

namespace Crispy_Waddle_Console.Models
{
    public class Photo
    {
        [JsonProperty("albumId")]
        public int AlbumId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        public string ToString() {
            return $"[{Id}] {Title}";
        }
    }


}

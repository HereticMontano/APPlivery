using Newtonsoft.Json;

namespace Repository.Entity
{
    public class Issue
    {
        //  [JsonPropertyName("Wind")]
        public int Id { get; set; }

        //[JsonPropertyName("Wind")]
        public string Aliase { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }
        [JsonProperty("cover_date")]
        public DateTime? CoverDate { get; set; }
        [JsonProperty("date_added")]
        public DateTime? DateAdded { get; set; }
        [JsonProperty("date_last_updated")]
        public DateTime? DateLastUpdated { get; set; }
        // [JsonPropertyName("deck")]
        public string Deck { get; set; }
        //  [JsonPropertyName("Wind")]
        public string Description { get; set; }

        public Image Image { get; set; }
        [JsonProperty("issue_number")]
        public string IssueNumber { get; set; }

        public string Name { get; set; }
    }

  
}


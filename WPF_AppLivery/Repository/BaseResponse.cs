using Newtonsoft.Json;

namespace Repository.Entity
{
    public class BaseResponse<T>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        [JsonProperty("number_of_page_results")]
        public int NumberOfPageResults { get; set; }
        [JsonProperty("number_of_total_results")]
        public int NumberOfTotalResults { get; set; }
        public T Results { get; set; }
    }
}

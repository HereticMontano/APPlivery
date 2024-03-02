using Repository.Dto;
using Repository.Entity;

namespace Repository
{
    public class ComicVineRepository
    {
        private HttpClient client = new HttpClient();
        private const string KEY_AND_FORMAT = "?api_key=fa4ae83a9db9f1e157812fc6e3136150f2ecdab8&format=json";

        public ComicVineRepository()
        {
            //A la api que uso no le gusta que no mandes user agent
            string customUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36";
            client.DefaultRequestHeaders.Add("User-Agent", customUserAgent);
            client.BaseAddress = new Uri("https://comicvine.gamespot.com/api/");
        }
        public async Task<BaseResponse<List<Issue>>> GetIssuesByAuthor(int id)
        {
            //Esta api no permite obtener comic basados en el autor, asique voy a simular traer distincos comics
            HttpResponseMessage response = await client.GetAsync($"issues/{KEY_AND_FORMAT}&offset={new Random().Next(99400)}" );
            if (response.IsSuccessStatusCode)
            {

                return await response.Content.ReadAsAsync<BaseResponse<List<Issue>>>();

            }
            return null;
        }

        public async Task<BaseResponse<List<People>>> GetPeople(PeopleFilter filter)
        {
            var filterByName = string.IsNullOrWhiteSpace(filter.NameArtist) ? string.Empty : $"name:{filter.NameArtist}";
            HttpResponseMessage response = await client.GetAsync($"people/{KEY_AND_FORMAT}&offset={filter.Offset}&filter={filterByName}&sort=name:{filter.ShortByName}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<BaseResponse<List<People>>>();
            }
            return null;
        }
    }
}
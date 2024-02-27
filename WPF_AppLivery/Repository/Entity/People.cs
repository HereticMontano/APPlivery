using Newtonsoft.Json;

namespace Repository.Entity
{
    public class People
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Deck { get; set; }

        public Image Image { get; set; }
    }
}


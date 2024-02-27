using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Image
    {
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
        [JsonProperty("medium_url")]
        public string MediumUrl { get; set; }
        [JsonProperty("screen_url")]
        public string ScreenUrl { get; set; }

        //"icon_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/square_avatar\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"medium_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/scale_medium\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"screen_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/screen_medium\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"screen_large_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/screen_kubrick\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"small_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/scale_small\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"super_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/scale_large\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"thumb_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/scale_avatar\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"tiny_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/square_mini\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"original_url":"https:\/\/comicvine.gamespot.com\/a\/uploads\/original\/1\/17880\/391363-21599-130474-1-the-ultimate-spider.jpg",
        //"image_tags":"All Images"
    }
}

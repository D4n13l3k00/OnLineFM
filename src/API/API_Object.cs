using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineFM.API
{
    class API_Object
    {
        [JsonProperty("changeuuid")]
        public string Changeuuid { get; set; }

        [JsonProperty("stationuuid")]
        public string Stationuuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_resolved")]
        public string UrlResolved { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countrycode")]
        public string Countrycode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("lastchangetime")]
        public string Lastchangetime { get; set; }

        [JsonProperty("codec")]
        public string Codec { get; set; }

        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty("hls")]
        public int Hls { get; set; }

        [JsonProperty("lastcheckok")]
        public int Lastcheckok { get; set; }

        [JsonProperty("lastchecktime")]
        public string Lastchecktime { get; set; }

        [JsonProperty("lastcheckoktime")]
        public string Lastcheckoktime { get; set; }

        [JsonProperty("lastlocalchecktime")]
        public string Lastlocalchecktime { get; set; }

        [JsonProperty("clicktimestamp")]
        public string Clicktimestamp { get; set; }

        [JsonProperty("clickcount")]
        public int Clickcount { get; set; }

        [JsonProperty("clicktrend")]
        public int Clicktrend { get; set; }
    }
}

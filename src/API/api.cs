using System.Text;
using Newtonsoft.Json;
using Leaf.xNet;
using System.Collections.Generic;

namespace OnLineFM.API
{
    internal static class api
    {
        internal static List<API_Object> getStations(string request = "lofi")
        {
            var data = new RequestParams {};
            data["name"] = request;
            string list = Encoding.UTF8.GetString(new HttpRequest().Get("https://nl1.api.radio-browser.info/json/stations/search", data).ToBytes());
            return JsonConvert.DeserializeObject<List<API_Object>>(list);
        }
    }
}

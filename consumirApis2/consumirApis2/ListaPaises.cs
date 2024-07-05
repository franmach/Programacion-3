using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumirApis2
{
    public class ListaPaises
    {
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public string Success { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public List<Pais> listaPaises { get; set; }
    }
    public partial class Pais
    {
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("country_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryKey { get; set; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("country_iso2")]
        public object CountryIso2 { get; set; }

        [JsonProperty("country_logo", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CountryLogo { get; set; }
    }
}

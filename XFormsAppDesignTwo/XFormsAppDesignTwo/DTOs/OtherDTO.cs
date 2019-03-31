using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFormsAppDesignTwo.DTOs
{
    class OtherDTORequest
    {
        public string ID { get; }

        public OtherDTORequest(string id)
        {
            this.ID = id;
        }

        public override string ToString()
        {
            return string.Format(Config.Settings.Current.URLQuery, ID);
        }
    }

    class OtherDTOResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}

using System;
using System.Collections.Generic;


namespace Inclock.VO
{    
    public class FeedBack
    {
        [Newtonsoft.Json.JsonProperty("Mensagem")]
        public string Mensagem { get; set; }
        [Newtonsoft.Json.JsonProperty("Status")]
        public bool Status { get;  set; } // true == tudo OK 

        public FeedBack()
        {
            
        }
    }
    public class MapedFeedBack
    {
        [Newtonsoft.Json.JsonProperty("CheckPointResult")]
        public FeedBack CheckPointResult { get; set; }
    }
}

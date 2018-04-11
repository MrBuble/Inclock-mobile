using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Inclock.BL.Rest
{
    class Client : HttpClient
    {
        private string uri = "http://inclock.gearhostpreview.com/";
        
        public Uri RequestUri
        {
            
            get
            {
                return new Uri(uri);
            }
        }
        public Client()
        {
            HttpClient client = new HttpClient();
            
        }
    }
}

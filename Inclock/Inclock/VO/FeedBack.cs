using System;
using System.Collections.Generic;


namespace Inclock.VO
{
    public class FeedBack
    {
        public string Mensagem { get; set; }
        public bool Status { get;  set; } // true == tudo OK 

        public FeedBack()
        {
            
        }
    }
}

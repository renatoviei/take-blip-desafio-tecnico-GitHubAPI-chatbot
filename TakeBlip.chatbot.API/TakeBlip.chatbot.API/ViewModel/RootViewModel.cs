using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeBlip.chatbot.API.ViewModel
{
    public class RootViewModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public DateTime created_at { get; set; }

        public string language { get; set; }
    }
}

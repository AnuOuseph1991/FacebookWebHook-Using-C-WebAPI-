using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialWebHooks.Models
{
    public class Feed
    {
        public string field { get; set; }
        public value value { get; set; }
    }

        public class value
        {
            public string item { get; set; }
            public string post_id { get; set; }
            public string verb { get; set; }
            public int published { get; set; }
            public string message { get; set; }
        }
    }
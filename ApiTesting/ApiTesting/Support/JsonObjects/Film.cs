﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting.Support.JsonObjects
{
    public class Film
    {
            public string title { get; set; }
            public int episode_id { get; set; }
            public string opening_crawl { get; set; }
            public string director { get; set; }
            public string producer { get; set; }
            public string release_date { get; set; }
            public string[] characters { get; set; }
            public string[] planets { get; set; }
            public string[] starships { get; set; }
            public string[] vehicles { get; set; }
            public string[] species { get; set; }
            public DateTime created { get; set; }
            public DateTime edited { get; set; }
            public string url { get; set; }

    }
}

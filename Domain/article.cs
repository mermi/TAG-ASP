using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class article
    {
        public int id_article { get; set; }
        public byte[] image { get; set; }
        public Nullable<System.DateTime> pubDate { get; set; }
        public string text { get; set; }
        public string title { get; set; }
        public string video { get; set; }
        public Nullable<int> teamMedia { get; set; }
        public virtual team team { get; set; }
    }
}

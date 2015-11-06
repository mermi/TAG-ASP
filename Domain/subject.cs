using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class subject
    {
        public subject()
        {
            this.publications = new List<publication>();
        }

        public int id_subject { get; set; }
        public string message { get; set; }
        public string name_subject { get; set; }
        public Nullable<int> categoryForums { get; set; }
        public virtual categoryforum categoryforum { get; set; }
        public virtual ICollection<publication> publications { get; set; }
    }
}

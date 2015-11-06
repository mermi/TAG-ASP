using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class categoryforum
    {
        public categoryforum()
        {
            this.subjects = new List<subject>();
        }

        public int id_category { get; set; }
        public string label { get; set; }
        public virtual ICollection<subject> subjects { get; set; }
    }
}

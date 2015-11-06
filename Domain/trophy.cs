using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class trophy
    {
        public int id_event { get; set; }
        public int id_gamer { get; set; }
        public string description { get; set; }
        public Nullable<int> rankTrophy { get; set; }
        public virtual @Event @event { get; set; }
        public virtual gamer gamer { get; set; }
    }
}

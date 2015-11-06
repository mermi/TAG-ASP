using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class vote
    {
        public int idGamer { get; set; }
        public Nullable<int> number_vote { get; set; }
        public virtual gamer gamer { get; set; }
    }
}

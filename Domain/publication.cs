using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class publication
    {
        public int id_gamer { get; set; }
        public int id_subject { get; set; }
        public string label { get; set; }
        public virtual gamer gamer { get; set; }
        public virtual subject subject { get; set; }
    }
}

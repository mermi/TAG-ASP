using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class contribution
    {
        public int id_event { get; set; }
        public int id_sponsor { get; set; }
        public float amount { get; set; }
        public string description { get; set; }
        public virtual sponsor sponsor { get; set; }
        public virtual @Event @event { get; set; }
    }
}

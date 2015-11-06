using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class equipment
    {
        public int id_equipement { get; set; }
        public string label { get; set; }
        public int quantity { get; set; }
        public Nullable<int> teamLogistics { get; set; }
        public Nullable<int> typeEquipment { get; set; }
        public virtual team team { get; set; }
        public virtual typeequipment typeequipment1 { get; set; }
    }
}

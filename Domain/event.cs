using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Event
    {
        public @Event()
        {
            this.contributions = new List<contribution>();
            this.trophies = new List<trophy>();
        }

        public int id_event { get; set; }
        public Nullable<System.DateTime> date_event { get; set; }
        public string name_event { get; set; }
        public int numberOfReservation { get; set; }
        public bool streaming { get; set; }
        public bool tournament { get; set; }
        public string type_event { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public Nullable<int> teamOrganisation { get; set; }
        public virtual ICollection<contribution> contributions { get; set; }
        public virtual ICollection<trophy> trophies { get; set; }
        public virtual team team { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class sponsor
    {
        public sponsor()
        {
            this.contributions = new List<contribution>();
        }

        public int id_sponsor { get; set; }
        public Nullable<System.DateTime> dateEnd { get; set; }
        public Nullable<System.DateTime> dateStart { get; set; }
        public string email { get; set; }
        public string name_contact_sponsor { get; set; }
        public string name_sponsor { get; set; }
        public Nullable<int> teamSponsor { get; set; }
        public virtual ICollection<contribution> contributions { get; set; }
        public virtual team team { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class gamer
    {
        public gamer()
        {
            this.publications = new List<publication>();
            this.trophies = new List<trophy>();
        }

        public int id { get; set; }
        public Nullable<int> age { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public byte[] image { get; set; }
        public string lastName { get; set; }
        public int numtel { get; set; }
        public string pwd { get; set; }
        public int rank { get; set; }
        public int record { get; set; }
        public Nullable<int> role { get; set; }
        public Nullable<int> team { get; set; }
        public virtual team team1 { get; set; }
        public virtual ICollection<publication> publications { get; set; }
        public virtual ICollection<trophy> trophies { get; set; }
        public virtual vote vote { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class team
    {
        public team()
        {
            this.articles = new List<article>();
            this.equipments = new List<equipment>();
            this.events = new List<@Event>();
            this.gamers = new List<gamer>();
            this.sponsors = new List<sponsor>();
        }

        public int id_team { get; set; }
        public int max_members { get; set; }
        public string name { get; set; }
        public virtual ICollection<article> articles { get; set; }
        public virtual ICollection<equipment> equipments { get; set; }
        public virtual ICollection<@Event> events { get; set; }
        public virtual ICollection<gamer> gamers { get; set; }
        public virtual ICollection<sponsor> sponsors { get; set; }
    }
}

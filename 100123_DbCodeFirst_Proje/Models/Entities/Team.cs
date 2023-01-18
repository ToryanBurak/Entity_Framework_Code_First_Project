using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100123_DbCodeFirst_Proje.Models.Entities
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public int FounderID { get; set; }
        public int CoachID { get; set; }

        //Relational Property

        public virtual DbSet<Player> Players { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual Founder Founder { get; set; }
    }
}

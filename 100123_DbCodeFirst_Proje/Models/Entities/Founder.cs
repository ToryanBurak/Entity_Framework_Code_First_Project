using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100123_DbCodeFirst_Proje.Models.Entities
{
    public class Founder:BaseEntity
    {
        public string Name { get; set; }
        public int TeamID { get; set; }

        //Relational Property

        public virtual Team Team { get; set; }
    }
}

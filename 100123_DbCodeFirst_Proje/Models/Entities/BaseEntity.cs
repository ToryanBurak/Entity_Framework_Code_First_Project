using _100123_DbCodeFirst_Proje.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100123_DbCodeFirst_Proje.Models.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}

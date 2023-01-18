using _100123_DbCodeFirst_Proje.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100123_DbCodeFirst_Proje.Design_Patterns.Singleton_Pattern
{
    using Models.Context;
    public class DbTool
    {
        DbTool() { }
        static MyContext dbInstance;
        public static MyContext DBInstance
        {
            get
            {
                if (dbInstance == null)
                {
                    dbInstance = new MyContext();
                }
                return dbInstance;
            }
        }
    }
}

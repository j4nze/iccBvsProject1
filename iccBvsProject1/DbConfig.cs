using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iccBvsProject1
{
    class DbConfig
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bvsDb;Integrated Security=True;Connect Timeout=30";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDWEEK_5_1.BL
{
    class AdminBL
    {
        public string username;
        public string password;

        public AdminBL(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_pd_1.BL.cs
{
    public class Subject
    {
        public string Code;
        public int CreditHours;
        public string Type;

        public Subject(string code, int creditHours, string type)
        {
            Code = code;
            CreditHours = creditHours;
            Type = type;
        }
    }

}

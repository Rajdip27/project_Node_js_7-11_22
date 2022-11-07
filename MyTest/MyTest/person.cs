using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class person
    {
        public string firstName;
        public string MiddleNamw;
        public string LastName;


        public string GetFullName()
        {
            string fullName = firstName + " " + MiddleNamw + " " + LastName;
            return fullName;

        }



    }
}

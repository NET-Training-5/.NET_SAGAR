using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Honda
    {
        static void Main(String[] args) 
        {
            Vehicles v1 = new Vehicles();
            v1.brand = "Honda";
            v1.manufactured_year = DateTime.Now;
            v1.model = "City";


            Vehicles v2 = new Vehicles();
            v2.brand = "Honda";
            v2.manufactured_year= DateTime.Now;
            v2.model = "Civic";

        }
    }
}

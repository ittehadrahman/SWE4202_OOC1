using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Seat
    {
        public string comforatability;
        public Boolean seatwarmer;
        public string getInfo()
        {
            return comforatability+"\t"+seatwarmer;
        }
    }
}

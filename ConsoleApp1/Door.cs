using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Door
    {
        public string position;
        public string movementDirection;
        public string getInfo()
        {
            return position+"\t"+movementDirection;
        }

    }
}

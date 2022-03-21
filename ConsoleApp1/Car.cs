using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public Door door = new Door();
        public Wheel wheel = new Wheel();
        public Engine engine = new Engine();
        public Seat seat = new Seat();
        public int maximumAcceleration;
        public int fuelCapacity;

        public string Display()
        {
            return Convert.ToString(maximumAcceleration) + Convert.ToString(fuelCapacity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Engine
    {
        public string MaxFuelConsumptionRate;
        public string MaxEngineProductionRate;
        public string AverageRPM;
        public string getInfo()
        {
            return MaxFuelConsumptionRate + "\t" + MaxEngineProductionRate+"\t"+AverageRPM;
        }
    }
}

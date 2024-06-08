using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Wheel
    {
        public string producer {  get; set; }
        public float airPressure {  get; set; }
        public float maxAirPressure {  get; set; }
        
        public Wheel(string producer, float airPressure, float maxAirPressure)
        {
            this.producer = producer;
            this.airPressure = airPressure;
            this.maxAirPressure = maxAirPressure;
        }

        public void filllAir()
        {
            this.airPressure = maxAirPressure;
            Console.WriteLine("air wass filled");
        }

    }
}

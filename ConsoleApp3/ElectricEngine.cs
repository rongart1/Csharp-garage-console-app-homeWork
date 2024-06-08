using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ElectricEngine : Engine
    {
        public float energyTimeLeft {  get; set; }
        public float maxEnergyTime {  get; set; }

        public ElectricEngine(float maxEnergyTime) {
            this.energyTimeLeft = 0;
            this.maxEnergyTime = maxEnergyTime;
        }
        public override void fill()
        {
            this.energyTimeLeft = maxEnergyTime;
        }
    }
}

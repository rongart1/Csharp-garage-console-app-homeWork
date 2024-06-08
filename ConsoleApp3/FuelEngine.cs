using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FuelEngine :Engine, Iegniteable
    {
        public string fuelType {  get; set; }
        public float fuelAmount {  get; set; }
        public float maxFuelAmount {  get; set; }    

        public FuelEngine(string fuelType, float maxFuelAmount)
        {
            this.fuelType = fuelType;
            this.fuelAmount = 0;
            this.maxFuelAmount = maxFuelAmount;
        }

        public override void fill()
        {
            this.fuelAmount = maxFuelAmount;
        }

    }
}

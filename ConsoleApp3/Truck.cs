using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Truck : Veichel
    {
        public float heigth { get; set; }
        public override string modle { get; set; }
        public override string id { get; set; }
        public override Engine engine { get; set; }
        public override List<Wheel> wheels { get; set; }
        public override string ownerName { get; set; }
        public override string ownerPhoneNumber { get; set; }
        public override char status { get; set; }
        public Truck(string modle, string id, Engine engine, List<Wheel> wheels, float heigth)
        {
            this.ownerName = "my company";
            this.ownerPhoneNumber = "0000000000";
            this.status = status;

            this.modle = modle;
            this.id = id;
            this.engine = engine;
            this.wheels = wheels;
            this.heigth = heigth;
        }

        public override void fillWheels()
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.filllAir();
            }
            Console.WriteLine("all tires are filled with air");
        }

        public override string ToString()
        {
            return string.Format(
                "Height: {0}\n" +
                "Model: {1}\n" +
                "ID: {2}\n" +
                "Engine: {3}\n" +
                "Wheels: {4}\n" +
                "Owner Name: {5}\n" +
                "Owner Phone Number: {6}\n" +
                "Status: {7}\n",
                heigth,
                modle,
                id,
                engine != null ? engine.ToString() : "null",
                wheels != null ? string.Join(", ", wheels) : "null",
                ownerName,
                ownerPhoneNumber,
                status
            );
        }

    }
}

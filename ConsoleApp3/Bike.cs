using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Bike : Veichel
    {
        public string licenseType { get; set; }
        public int volume { get; set; }
        public override string modle { get; set; }
        public override string id { get; set; }
        public override Engine engine { get; set; }
        public override List<Wheel> wheels { get; set; }
        public override string ownerName { get; set; }
        public override string ownerPhoneNumber { get; set; }
        public override char status { get; set; }

        public Bike(string modle, string id, Engine engine, List<Wheel> wheels, int volume, string licenseType)
        {
            this.ownerName = "my company";
            this.ownerPhoneNumber = "0000000000";
            this.status = status;

            this.modle = modle;
            this.id = id;
            this.engine = engine; ;
            this.wheels = wheels;
            this.volume = volume;
            this.licenseType = licenseType;
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
                        "License Type: {0}\n" +
                        "Volume: {1}\n" +
                        "Model: {2}\n" +
                        "ID: {3}\n" +
                        "Engine: {4}\n" +
                        "Wheels: {5}\n" +
                        "Owner Name: {6}\n" +
                        "Owner Phone Number: {7}\n" +
                        "Status: {8}\n",
                        licenseType,
                        volume,
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

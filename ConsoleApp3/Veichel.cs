using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Veichel
    {
        public abstract string ownerName { get; set; }
        public abstract string ownerPhoneNumber { get; set; }
        public abstract char status {  get; set; }
        public abstract string modle { get; set; }
        public abstract string id {  get; set; }
        public abstract Engine engine { get; set; }

        public abstract List<Wheel> wheels { get; set; }

        public abstract string ToString();
        public abstract void fillWheels();
    }
}

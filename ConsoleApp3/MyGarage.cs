using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    class MyGarage
    {
        static List<Veichel> garage = new List<Veichel> { }; 






        public static void createNewVichel()
        {
            Veichel newVeichel;
            string veichelType ="";
            bool choosed = false;
            while (!choosed)
            {
                Console.WriteLine("chose a veichel type between truck, car, bike");
                veichelType = Console.ReadLine();

                choosed = veichelType.Equals("car") || veichelType.Equals("truck") || veichelType.Equals("bike");

                if (!choosed)
                {
                    Console.WriteLine("you entered an invalid input");
                }
            }

            Console.WriteLine("enter veichel model");
            String model =  Console.ReadLine();

            Console.WriteLine("enter veichel plate id");
            String id = Console.ReadLine();

            Console.WriteLine("type 1 for fuel engine and 2 for electric");
            bool again = false;
            Engine engine =null;
            String engineChoice = null;
            do
            {
                Console.WriteLine("type 1 for fuel engine and 2 for electric");
                engineChoice = Console.ReadLine();
                if (engineChoice.Equals("1"))
                {
                    Console.WriteLine("enter a max fuel amount for your engine");
                    float maxFuel;
                    try
                    {
                        maxFuel = float.Parse(Console.ReadLine());
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                        Console.WriteLine("there was an error in the input max fuel set to 200");
                        maxFuel = 200;
                    }
                    Console.WriteLine("enter your engine's fuel type");
                    string fuelType = Console.ReadLine();
                    engine = new FuelEngine(fuelType, maxFuel);
                    again = false;
                }
                else if (engineChoice.Equals("2"))
                {
                    Console.WriteLine("enter a max energy time for your engine");
                    float maxEnergy;
                    try
                    {
                        maxEnergy = float.Parse(Console.ReadLine());
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                        Console.WriteLine("there was an error in the input max energy set to 10.5h");
                        maxEnergy = 10.5f;
                    }
                    engine = new ElectricEngine(maxEnergy);
                    again = false;
                }
                else
                {
                    Console.WriteLine("you didnt choose a valid option");
                    again = true;
                }
            }while (again);


            Console.WriteLine("choose a what wheel company you want");
            string wheelCompany = Console.ReadLine();

            Console.WriteLine("what max air pressiure you want for the wheels");
            float maxAir;
            try
            {
                maxAir = float.Parse(Console.ReadLine());
            }
            catch(Exception err)
            {
                Console.WriteLine("some error happened while getting the input max pressuire set to 200");
                maxAir = 200;
            }

            int wheelCount;
            if (veichelType.Equals("car") || veichelType.Equals("truck"))
            {
                wheelCount = 4;
            }
            else
            {
                wheelCount = 2;
            }
            List<Wheel> wheels = new List<Wheel> {};
            for(int i = 0; i < wheelCount; i++) 
            {
                wheels.Append(new Wheel(wheelCompany,0,maxAir));
            }


            if (veichelType.Equals("car"))
            {
                int doorCount =4;
                Console.WriteLine("enter door count");
                try
                {
                    doorCount = int.Parse(Console.ReadLine());
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                    Console.WriteLine("error happened door count got default value of 4");
                }

                Console.WriteLine("choose car color");
                string carColor = Console.ReadLine();

                newVeichel = new Car(model, id, engine, wheels, doorCount, carColor);
            }

            else if (veichelType.Equals("truck"))
            {
                float heigth = 3.5f;
                Console.WriteLine("enter truck heigth");
                try
                {
                    heigth = float.Parse(Console.ReadLine());
                }
                catch(Exception err)
                {
                    Console.WriteLine(err);
                    Console.WriteLine("there was an error heigth got default value of 3.5m");
                }
                newVeichel = new Truck(model, id, engine, wheels, heigth);
            }
            else
            {
                Console.WriteLine("enter bike license type");
                string licenseType = Console.ReadLine();
                int volume = 300;
                Console.WriteLine("enter bike volume");
                try
                {
                    volume = int.Parse(Console.ReadLine());
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                    Console.WriteLine("there was an error volume auto set to 300");
                }
                newVeichel = new Bike(model, id, engine, wheels, volume, licenseType);
            }

            garage.Add(newVeichel);
            Console.WriteLine("the new car was created and was added to garage");
        }

        public static void showAllPlates()
        {
            Console.WriteLine("current plates: ");
            foreach(Veichel v in garage)
            {
                Console.Write(v.id+" ,");
            }
            Console.WriteLine("");
        }

        public static void buyVeichel()
        {
            Veichel myVehicle = null;
            bool exit = false;
            do
            {
                Console.WriteLine("enter the plate number of the veichel you want to buy");
                string chosenId = Console.ReadLine();

                myVehicle = findByPlate(chosenId);
                if(myVehicle == null)
                {
                    Console.WriteLine("couldnt find a veichel with that plate");
                    Console.WriteLine("type 1 if if you want to countinue searching and 2 to stop");
                    string choise = Console.ReadLine();
                    if (choise.Equals("2"))
                    {
                        exit = true;
                    }
                }
                else
                {
                    exit=true;
                }
            }
            while (!exit);
            

            Console.WriteLine("enter your name");
            string buyerName = Console.ReadLine();

            Console.WriteLine("enter your phone number");
            string buyerPhone = Console.ReadLine();

          

            myVehicle.status = 'B';
            myVehicle.ownerName = buyerName;
            myVehicle.ownerPhoneNumber = buyerPhone;

            Console.WriteLine("you are now the owner of the car");
        }
        public static Veichel findByPlate(string id)
        {
            foreach (Veichel v in garage)
            {
                if (v.id.Equals(id))
                {
                    return v;
                }
            }
            return null;
        }

        public static void fillUp()
        {
            Veichel v = null;
            string id = null;
            do
            {
                Console.WriteLine("enter the desired veichel id ot type stop to exit");
                id = Console.ReadLine();
                v = findByPlate(id);
                if (id.Equals("stop"))
                {
                    break;
                }
                else if (v == null)
                {
                    Console.WriteLine("couldnt find such veichel try again");
                }
            } while (v == null);

            v.engine.fill();
            Console.WriteLine("engine was filled");
        }

        public static void printV()
        {
            
            Veichel v = null;
            string id = null;
            
            do
            {
                Console.WriteLine("enter the desired veichel id ot type stop to exit");
                id = Console.ReadLine();
                v = findByPlate(id);
                if (id.Equals("stop"))
                {
                   break;
                }
                else if(v == null)
                {
                    Console.WriteLine("couldnt find such veichel try again");
                }
            }while (v == null);
            
            Console.WriteLine(v.ToString());
        }
    }

   
}

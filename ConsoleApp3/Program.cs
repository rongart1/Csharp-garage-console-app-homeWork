using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choise = '0';
            do
            {
                Console.WriteLine(
                    "type 1 to create a new veichel\n"+
                    "type 2 to show all plates in garage\n"+
                    "type 3 to buy a veichel\n" +
                    "type 4 to show a spesific vehicel details\n"+
                    "type 5 to fill up a vehichel\n"+
                    "type 6 to exit the program");
                bool validKey = false;
                do
                {
                    try
                    {
                        choise = char.Parse(Console.ReadLine());
                        validKey = true;
                    }
                    catch
                    {
                        Console.WriteLine("the key you entered isnt valid try again");
                    }

                } while (!validKey);
                
                switch (choise)
                {
                    case '1':
                        MyGarage.createNewVichel();
                        break;

                    case '2':
                        MyGarage.showAllPlates();
                        break;

                    case '3':
                        MyGarage.buyVeichel();
                        break;

                    case '4':
                        MyGarage.printV();
                        break;

                    case '5':
                        MyGarage.fillUp();
                        break;

                    default:
                        Console.WriteLine("no such choise");
                        break;
                }
                

            } while (choise != '6');
            
        }
    }
}

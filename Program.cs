using System;
using System.Collections.Generic;

namespace queryCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoopVariable = true;
            string InputCatcher = "";
            while(LoopVariable)
            {
                InputCatcher = "";
                Console.WriteLine("Input 0 For User options And 1 for Owner Options or press Enter to exit");
                InputCatcher = Console.ReadLine();



                if("0" == InputCatcher)
                {



                    Console.WriteLine("input a filter field:\n mpg,cylinders,displacement,horsepower,weight,acceleration,modelyear,origin,carname\nand filter word to display cars filtered by");
                    InputCatcher = Console.ReadLine();
                    Inventory myInv = new Inventory();
                    Console.WriteLine(InputCatcher.Split(" ")[0]);
                    Console.WriteLine(InputCatcher.Split(" ")[1]);

                    IEnumerable<Car> filteredList = myInv.FilterCars(InputCatcher.Split(" ")[1],InputCatcher.Split(" ")[0]);
                    string outPut = "";
                    foreach(Car item in filteredList)
                        {
                            outPut = outPut + item+"\n";
                        }
                        Console.WriteLine(outPut);
                    



                }else if("1" == InputCatcher)
                {
                    Console.WriteLine("OWNER CASE");
                }else if(InputCatcher == ""){
                    LoopVariable = false;
                }else
                {
                    Console.WriteLine("INVALID OPTION PLEASE PICK : Input 0 For User options And 1 for Owner Options or press Enter to exit");
                    
                }
            }
        }
    }
}

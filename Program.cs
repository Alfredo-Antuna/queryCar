using System;

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
                    Inventory myInv = new Inventory();
                    Console.WriteLine("USER CASE");
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

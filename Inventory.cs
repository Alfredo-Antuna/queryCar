using System;
using System.Collections.Generic;
using System.IO;


namespace queryCar
{
    


    public class Inventory
    {
        private List<Car> _carList = new List<Car>();
        


        public Inventory()
        {
            StreamReader StreamReader = new StreamReader(@"Data/auto-mpg.csv");
            string line = StreamReader.ReadLine();
             while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = StreamReader.ReadLine();
                }
                    //close the file
                    StreamReader.Close();
                    Console.ReadLine();

        }

    }


}






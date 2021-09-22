using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace queryCar
{
    


    public class Inventory
    {
        private List<Car> _carList = new List<Car>();
        


        public Inventory()
        {
            
           try{
            
            //write the line to console window
            // Console.WriteLine(line);
            //Read the next line
            var lines= File.ReadAllLines(@"Data/auto-mpg.csv");
            var rand = new Random();
            foreach(var line in lines){
                decimal price = rand.Next(10000,20000);//(decimal)(rand.NextDouble() * (20000 - 10000) + 10000);
                var parsedLine = line.Split(',');
                if(parsedLine[3] == "?"){parsedLine[3] = "100";}
                _carList.Add(new Car(
                    price,
                    decimal.Parse(parsedLine[0]),
                    Int32.Parse(parsedLine[1]),
                    decimal.Parse(parsedLine[2]),
                    Int32.Parse(parsedLine[3]),
                    Int32.Parse(parsedLine[4]),
                    decimal.Parse(parsedLine[5]),
                    Int32.Parse(parsedLine[6]),
                    Int32.Parse(parsedLine[7]),
                    parsedLine[8]));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
                


        }



        public override string ToString(){
            string outPut = "";
            foreach(Car item in _carList)
                {
                    outPut = outPut + item+"\n";
                }
                return outPut;
        }
       





                    
                   
        public IEnumerable<Car> FilterCars(string filter , String filterField){
            Console.WriteLine("in filterCars");
            IEnumerable<Car> FilteredSelection;


            switch (filterField)
            {
                case "price":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.Price == decimal.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "mpg":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.mpg == decimal.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "cylinders" :
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.cylinders == Int32.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "displacement":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.displacement == decimal.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "horsepower":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.horsepower == Int32.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "weight":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.weight == Int32.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "acceleration":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.acceleration == Int32.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "modelyear":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.modelYear == Int32.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "origin":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.origin == Int32.Parse(filter)
                    select Car;
                    return FilteredSelection;
                    
                }
                case "carname":
                {
                    FilteredSelection =
                    from Car in _carList
                    where Car.carname == filter
                    select Car;
                    return FilteredSelection;
                   

                }
            }
             FilteredSelection =
                    from Car in _carList
                    where Car.carname == filter
                    select Car;
                    return FilteredSelection;
        
        
        }


        public void SearchCarsByKeyword(){

        }
    }




    
    

}









using System;
using System.Collections.Generic;
namespace queryCar
{




    public record Car(
        decimal Price,
        decimal mpg,
        int cylinders,
        decimal displacement,
        int horsepower,
        int weight,
        decimal acceleration,
        int modelYear,
        int origin,
        string carname)
    {

    }
}
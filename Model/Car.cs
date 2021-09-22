using System;

namespace queryCar
{




    public record Car(
        int mpg,
        int cylinders,
        int displacement,
        int horsepower,
        int weight,
        decimal acceleration,
        int modelYear,
        int origin,
        string carname)
    {

    }
}
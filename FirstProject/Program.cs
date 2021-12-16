using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        class Car
        {

            public override bool Equals(object? obj)
            {
                if (obj == null)
                {
                    return false;   
                }

                if(this.GetType() != obj.GetType())
                {
                    return false;
                }

                Car carObj = (Car)obj;

                return this.horsePower == carObj.horsePower;
            }
            public Car(int horsePower)
            {
                horsePower = horsePower;
            }
            public int horsePower { get; set; }
        }

        static void Main(string[] args)
        {
            int horsePower1 = 350;
            int horsePower2 = 350;

            bool valueTypeEquality  = horsePower1 == horsePower2;

            Car car1 = new Car(horsePower1);
            Car car2 = new Car(horsePower2);

            bool referenceTypeEquality = car1.Equals(car2);

            Console.WriteLine($"valueTypeEquality: {valueTypeEquality}");
            Console.WriteLine($"referenceTypeEquality: {referenceTypeEquality}");
        }
    }
}



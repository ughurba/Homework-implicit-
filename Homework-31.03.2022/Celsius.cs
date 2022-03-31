using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_31._03._2022
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree = degree;
        }
      
        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree - 273.15);
        }
    }
}

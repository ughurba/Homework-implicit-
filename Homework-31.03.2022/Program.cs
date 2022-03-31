using System;

namespace Homework_31._03._2022
{
    public class Program
    {
        public enum Currecy { Usd = 1, Eur, Try }
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(150);
            Celsius celsius = kelvin;
            Console.WriteLine(celsius.Degree);
            


        }
        
        public static double  Exchange(Currecy curs ,double azn)
        {
            
            if (curs is Currecy)
            {
                return azn * 1.7;
            }
            else
            {
                Console.WriteLine("wrong");
                return -1;
            }


        }

        }
    }


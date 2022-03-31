using System;

namespace Homework_31._03._2022
{
    public class Program
    {
        public enum Currecy { Usd = 1, Eur, Try }
        static void Main(string[] args)
        {
            //Kelvin kelvin = new Kelvin(150);
            //Celsius celsius = kelvin;
            //Console.WriteLine(celsius.Degree);
            Console.WriteLine("kurs qeyd edin ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case (int)Currecy.Usd:
                    Console.WriteLine(Exchange(Currecy.Usd, 170));
                    break;

                case (int)Currecy.Eur:

                    Console.WriteLine(Exchange(Currecy.Eur, 100));

                     break;

                case (int)Currecy.Try:

                    Console.WriteLine(Exchange(Currecy.Try, 100));
                    break;

            }
            


        }
        
        public static double  Exchange(Currecy curs ,double azn)
        {
            
            if (curs is Currecy)
            {
                if(Currecy.Usd == curs)
                {
                    return azn * 0.59;
                }else if (Currecy.Eur == curs)
                {
                    return azn * 0.53;
                }else if (Currecy.Try == curs)
                {
                    return azn * 8.63;
                }  
       
            }
            Console.WriteLine("wrong");
            return -1;

        }

        }
    }


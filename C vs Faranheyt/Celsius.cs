using System;
using System.Collections.Generic;
using System.Text;

namespace C_vs_Faranheyt
{
    internal class Celsius
    {
        double sum;

        public double Degree { get; set; }


        public double ToCelsius()

        {
            return (Degree * 1.8) + 32;

        }
        public void CCelsius(Celsius degree)

        {
            sum += degree.ToCelsius();
            Console.WriteLine(sum);

        }
       


    }   
}

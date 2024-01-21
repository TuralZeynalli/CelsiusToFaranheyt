using System;
using System.Collections.Generic;
using System.Text;

namespace C_vs_Faranheyt
{
    class Faranheyt
    {
        Double sum;

        public double Degree { get; set; }

        public double ToFaranheyt() 
        
        {
            return (Degree - 32) / 1.8;
        }

        public void FFaranheyt(Faranheyt degree) 
        
        {

            sum += degree.ToFaranheyt();

            Console.WriteLine(sum);
        }
    }
}

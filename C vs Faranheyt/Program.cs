using System;
using System.Collections.Generic;
using System.Text;

namespace C_vs_Faranheyt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Celsius celsiusToFaranheyt = new Celsius ()             
            {                
                Degree = 30         
            };

            Faranheyt faranheytToCelsius = new Faranheyt ()         
            { 
                Degree = 50           
            };

            celsiusToFaranheyt.CCelsius(celsiusToFaranheyt);

            faranheytToCelsius.FFaranheyt(faranheytToCelsius);

        }
    }
}

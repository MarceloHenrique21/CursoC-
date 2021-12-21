using System;
using System.Globalization;

  class arquivo1{

      public static void Main(){


         double A, B, C, a, b, c;


             Console.WriteLine("Digite as medidas do triangulo X: ");

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite as medidas do triangulo Y: ");

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (A + B + C) /2.0;

            double areaX = Math.Sqrt(p* (p - A) *(p - B) * (p - C));

            p = (a + b + c) / 2.0;

             double areaY = Math.Sqrt(p* (p - a) *(p - b) * (p - c));

             Console.WriteLine(" Area de X = "+ areaX.ToString("F4", CultureInfo.InvariantCulture));

             Console.WriteLine(" Area de Y = "+ areaY.ToString("F4", CultureInfo.InvariantCulture));

             if(areaX > areaY){

                 Console.WriteLine("Maior area é X");

             }else{

                 Console.WriteLine("AreaY é maior");

             }

            Console.WriteLine("pressione qualquer tecla para continuar");
            Console.ReadKey();

        }
        } 

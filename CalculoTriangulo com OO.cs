
using System.Globalization;
using arquivo4_inicio_programação_orientada_a_objetos;

class arquivo1{

 public static void Main(){


     Triangulo x, y;

     x = new Triangulo();

     y = new Triangulo();

 Console.WriteLine("Digite as medidas do triangulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite as medidas do triangulo Y: ");

             y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double p = (x.A + x.B + x.C) /2.0;

            double areaX = Math.Sqrt(p* (p - x.A) *(p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;

             double areaY = Math.Sqrt(p* (p - y.A) *(p - y.B) * (p - y.C));

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

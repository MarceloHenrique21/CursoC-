using System;
using System.Globalization;

class arquivo1{
    
 public static void Main(){

     Console.WriteLine("Estrutura base C#");

     Console.WriteLine("Digite um numero, um caracter e um numero quebrado");
     int n1 = int.Parse(Console.ReadLine());

     char ch = char.Parse(Console.ReadLine());

     double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

     Console.WriteLine("Voce digitou: ");
     Console.WriteLine(n1);
     Console.WriteLine(ch);
     Console.WriteLine(n2);



    Console.WriteLine("pressione qualquer tecla para continuar");
    Console.ReadKey();



}
}

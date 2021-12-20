using System;
using System.Globalization;

class arquivo1{
    
 public static void Main(){

     Console.WriteLine("Estrutura base C#");

     Console.WriteLine("Digite um numero, um caracter e um numero quebrado: ");
     int n1 = int.Parse(Console.ReadLine());

     char ch = char.Parse(Console.ReadLine());

     double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite um nome, sexo, idade e altura");
    String[] vetor = Console.ReadLine().Split(' ');
    String nome = vetor[0];
    char sexo = char.Parse(vetor[1]);
    int idade = int.Parse(vetor[2]);
    double altura = double.Parse(vetor[3]);



     Console.WriteLine("Voce digitou: ");
     Console.WriteLine(n1);
     Console.WriteLine(ch);
     Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
     Console.WriteLine(nome);
     Console.WriteLine(sexo);
     Console.WriteLine(idade);
     Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


    Console.WriteLine("pressione qualquer tecla para continuar");
    Console.ReadKey();



}
}

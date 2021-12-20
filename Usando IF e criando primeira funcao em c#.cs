using System;

class arquivo3{
        public static void Main(){

      //declaracao de variaveis e valores que a funcao utilizara
        Console.WriteLine("Digite tres numeros: ");

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        double resultado = Maior(n1, n2, n3);

        Console.WriteLine("Maior = " + resultado);




    // --------------------------- IF que eu fiz de teste 
        int A = 30;

        if (A < 20 || A != 30){

            Console.WriteLine("O A É MENOR QUE 20 OU É IGUAL A TRINTA");

           }else{

            Console.WriteLine("O A É MAIOR QUE 20");
        }
    //--------------------------------------------- Fim do IF
     




    Console.WriteLine("pressione qualquer tecla para continuar");
    Console.ReadKey();

}

//-----|funcao para calcular qual é o maior numero
    static int Maior(int a, int b, int c) {

        int m;
        
        if(a > b && a > c){
            m = a;

        } else if (b > c){

            m = b;

        } else{

            m = c;

        } return m;



    }
} 

using System;

class Aula24{
    static void Main(){
        ola();

        int valor1=0, valor2=0;

        valor1 = int.Parse(Console.ReadLine());
        valor2 = int.Parse(Console.ReadLine());

        soma(valor1, valor2);

        int resultado = multiplica(valor1, valor2);
        Console.WriteLine("A multiplicação de {0} * {1} é: {2}", valor1, valor2, resultado);
    }
       
    static void ola(){ //void não retorna nada;
        Console.WriteLine("Olá, mundo!!!");
        Console.WriteLine("Vamos aprender C#?");
    }
    static void soma(int num1, int num2){
        int res = num1+num2;
        Console.WriteLine("A soma de {0} + {1} é: {2}", num1, num2, res);

    }

    static int multiplica(int numero1, int numero2){
        int res = numero1*numero2;
        return res;
    }
    //Conjunto de instruções que podem ser chamados para serem execultados
}
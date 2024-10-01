using System;
class Aula08{
    static void Main (){

        int valor1, valor2, soma;
        string nome;

        Console.Write("Digite o 1° valor: ");
        valor1 =int.Parse(Console.ReadLine());
        Console.Write("Digite o 2° valor: ");
        valor2 =int.Parse(Console.ReadLine());

        soma = valor1 + valor2;

        Console.WriteLine("A soma de {0} + {1} = {2} ", valor1, valor2, soma);        
    }
}
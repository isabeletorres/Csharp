//Laços de repetição - for
using System;
class Aula19{
    static void Main (){
        
        int num=0;
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());

        for(int i=0; i<10; i++){
            Console.WriteLine("{0} * {1} = {2}", num, i+1, num*(i+1));
        }
    }
}
//Laços de repetição - While
using System;
class Aula20{
    static void Main (){
        
        int num=0, i=0;
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());

        while(i<10){
            Console.WriteLine("{0} * {1} = {2}", num, i+1, num*(i+1));
            i++;
        }

        /*for(int i=0; i<10; i++){
            Console.WriteLine("{0} * {1} = {2}", num, i+1, num*(i+1));
        }*/
    }
}
using System;
class Aula21{
    static void Main (){
        int num=0, i=0;
        
        string senha="123";
        string senharUser=" ";
        int tentativas=0;

        do {
            Console.Clear();
            Console.Write("Digite a senha: ");
            senharUser = Console.ReadLine();
            tentativas++;
        }while(senha !=senharUser);

        Console.WriteLine("Tentativas {0} ", tentativas);
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());

        do{
            Console.WriteLine("{0} * {1} = {2}", num, i+1, num*(i+1));
            i++;
        }while(i<10);
    }
}
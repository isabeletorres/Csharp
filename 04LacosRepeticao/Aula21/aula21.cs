using System;
class Principal{
    static void Main (){
        int num=0, i=0;
        
        string senha="123";
        string senharUser=" ";

        do {
            Console.Clear();
            Console.Write("Digite a senha: ");
            senharUser = Console.ReadLine();
        }while(senha !=senharUser);

        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        
        do{
            Console.WriteLine("{0} * {1} = {2}", num, i+1, num*(i+1));
            i++;
        }while(i<10);
    }
}
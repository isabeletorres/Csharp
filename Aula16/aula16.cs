using System;
class Aula16{
    static void Main (){
        int tempo=0;
        char escolha=' ';

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES: ");
        Console.WriteLine("Escolha o transporte: \n[a]: Avião\n[c]: Carro\n[o]: onibus");
        
        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a': 
            case 'A': 
                tempo =50;
                break;
            case 'c':
            case 'C':  
                tempo= 8*60;
                break;
            case 'o':
            case 'O':
                tempo = 11*60;
                break;
            default:
                tempo= -1;
                break;
        }
        if (tempo<0){
            Console.WriteLine("Transporte não reconhecido");
        } else {
            Console.WriteLine("Para o transporte escolhido o tempo é {0} minutos", tempo);
        }
        Console.Write("\nCalcular novamente? [S/N] ");
        escolha=char.Parse(Console.ReadLine());
        if (escolha == 'S' || escolha =='s'){
            goto inicio;
        } else{
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }
    }
}
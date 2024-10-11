using System;
//classes compostos por membros(variáveis e funções)

public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar(string n){
        nome=n;
        energia=100;
        vivo= true;
    }
    
    static public void info(){
        Console.WriteLine("Nome do Jogador: {0}", nome);
        Console.WriteLine("Energia do Jogador {0}", energia);
        Console.WriteLine("Estado do Jogador {0}\n", vivo);

    }
}
class Aula31{
    static void Main(){
        
        Jogador.iniciar("Bruno");
        Jogador.info();

    }
}
using System;
//classes compostos por membros(variáveis e funções)

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        nome=n;
        energia=100;
        vivo= true;
    }
    ~Jogador(){
        Console.WriteLine("Jogador foi removido!");
    }
}
class Aula29{
    static void Main(){
        string nome1 = Console.ReadLine();
        string nome2 = Console.ReadLine();
        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador(nome2);

        Console.WriteLine("Nome do jogador1: {0}", j1.nome );
        Console.WriteLine("Nome do jogador12: {0}", j2.nome );
    }
}
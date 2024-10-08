using System;
//classes compostos por membros(variáveis e funções)

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(){
        nome="";
        energia=100;
        vivo= true;
    }
    public Jogador(string n){
        nome=n;
        energia=100;
        vivo= true;
    }
    public Jogador(string n, int ene){
        nome=n;
        energia=ene;
        vivo= true;
    }
     public Jogador(string n, int ene, bool viv){
        nome=n;
        energia=ene;
        vivo= viv;
    }
    public void info(){
        Console.WriteLine("Nome do Jogador: {0}", nome);
        Console.WriteLine("Energia do Jogador {0}", energia);
        Console.WriteLine("Estado do Jogador {0}\n", vivo);

    }
}
class Aula30{
    static void Main(){
        
        Jogador J1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Théo", 100);
        Jogador j4 = new Jogador("Senegundesfirno", 0, false);

        J1.info(); 
        j2.info();
        j3.info();
        j4.info();

    }
}
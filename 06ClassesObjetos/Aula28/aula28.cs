using System;
//classes compostos por membros(variáveis e funções)

public class Jogador{
    public int energia=100;
    public bool vivo= true;

    
}
class Aula28{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;
        
        Console.WriteLine("Energia do jogador1: {0}", j1.energia );
        Console.WriteLine("Energia do jogador12: {0}", j1.energia );
    }
}
/* Corpo da classe
[ModificadorClasse] class NOME_DA_CLASS{
    //Variáveis  / propiedades
    [EspeecificadorAcesso] tipo NOME_PROPIEDADE;

    //Métodos
    [EspeecificadorAcesso] retorno NOME_MÉTODO([args1,...]){
            //  Corpo do método
    }
}
//ModificadorClasse: Define a visibilidade da classe
    //public: pública, sem restrição de visualização
    //abstract: Class-Base para outras classes, não podem ser instanciados a objeto dessa classe
    //sealed: classe não pode ser herdada
    //static: Classe não permite a instanciação de objetos e seus membros devem ser static

//EspecificadorAcesso: Onde o membro da classe pode ser acessado
    //public sem restrição de acesso
    //private: só podem ser acessadas pela própia classe
    //protected: podem ser acessados na propia  classe e nas derivadas
    //abstract: Os métodos  não tem implementação somente de cabeçalhos
    //sealed: o método não pode ser redefinido
    //virtual: o método pode ser redefinido em uma classe derivada
    //static: o método pode ser chamado mesmo se a instanciação de um objetos

*/
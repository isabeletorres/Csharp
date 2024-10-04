using System;
class Aula25{
    static void Main(){
        int num=10; //passagem por valor(novo espaço de memoria)
        dobrar(ref num);// passagem por referencia no endeço de momoria
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor){
        valor*=2;
    }
}
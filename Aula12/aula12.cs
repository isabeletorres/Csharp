// IF
using System;
class Principal{
    static void Main (){

        int nota1, nota2, nota3, nota4, res;
        res=nota1=nota2=nota3=nota4=0;
        string resultado="Reprovado";

        Console.Write("Digite 1° nota do aluno: ");
        nota1 = int.Parse(Console.ReadLine());
        Console.Write("Digite 2° nota do aluno: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.Write("Digite 3° nota do aluno: ");
        nota3 = int.Parse(Console.ReadLine());
        Console.Write("Digite 4° nota do aluno: ");
        nota4 = int.Parse(Console.ReadLine());
        
        res = nota1+nota2+nota3+nota4;
        if(res>=60){
            resultado = "Aprovado";
        } 

       Console.WriteLine("Nota: {0}. {1}", res, resultado);
    }
}
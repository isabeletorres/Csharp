//Arrays unidimensionais
using System;
class Aula17{
    static void Main (){
       // int n1, n2, n3, n4, n5;
        int[] numero = new int [5]; 
        int[] numero1 = new int [3]{55, 77, 99};
        int[] numero2 ={66, 77, 88, 123, 34}; 
        numero[0]=11;
        numero[1]=22;
        numero[2]=33;
        numero[3]=44;
        numero[4]=55;

        Console.WriteLine(numero[4]);
        Console.WriteLine(numero1[2]);
        Console.WriteLine(numero2[4]);
    }
}
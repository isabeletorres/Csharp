using System;
class Aula18{
    static void Main (){
        int [,] numero = new int[3, 5];
        /*
        10 20 30 40 50
        60 70 80 90 15
        25 35 45 55 65
        */
        numero[0, 0]=10;
        numero[0, 1]=20;
        numero[0, 2]=30;
        numero[0, 3]=40;
        numero[0, 4]=50;

        numero[1, 0]=60;
        numero[1, 1]=70;
        numero[1, 2]=80;
        numero[1, 3]=90;
        numero[1, 4]=15;

        numero[2, 0]=25;
        numero[2, 1]=35;
        numero[2, 2]=45;
        numero[2, 3]=55;
        numero[2, 4]=65;

        Console.Write(numero[1, 3]);
    }
}
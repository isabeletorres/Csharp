using System;
class Aula10{
    enum DiasSemana{Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};
    static void Main (){

        DiasSemana ds = (DiasSemana)3;
        int ds1 =(int)DiasSemana.Sexta;
        Console.WriteLine(ds);
        Console.WriteLine(ds1);
    }
}
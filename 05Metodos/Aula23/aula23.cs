using System;
class Aula23{
    static void Main(){
        int[] vetor1 = new int [5];
        int[] vetor2 = new int [5];
        int[] vetor3 = new int [5];
        int[,] matriz = new int[2, 5]{{11,22,00,44,55}, {66,77,88,99,00}};

        Random random = new Random();
        for (int i=0; i<vetor1.Length; i++){
            vetor1[i] = random.Next(50); // sem nada nos parenteses é qualquer número, um número é o valor max, dois numeros max e mim
        }

        Console.WriteLine("Elementos do vetor1: ");
        foreach (int n in vetor1){
            Console.WriteLine(n);
        }
        //public static int BinarySearch(array, valor); //MPOSIÇÃO DO ELEMENTO PROCURADO, caso mão encontrado retorno -1
        Console.WriteLine("BinarySearch");
        int procurado = 33; // numero que eu quero encontrar
        int pos = Array.BinarySearch(vetor1, procurado); //posição
        Console.WriteLine("Valor {0} está na posição: {1}", procurado, pos);
        Console.WriteLine("-----------------------------------------------");

        //public static void Copy(Ar_origem,Ar_destino, qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2) {
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------");

        //public void copyTo(Ar_destino, a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor );
        Console.WriteLine("--------------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}", menorIndiceVetor);
        Console.WriteLine("--------------------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior Índice do vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("--------------------------------------------------");

        //public object GetValue(Long indice);
        Console.WriteLine("GetValue");
        int valor0 =Convert.ToInt32(vetor1.GetValue(3));
        int valor1 =Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da posição 3 do veto1: {0}", valor0);
        Console.WriteLine("--------------------------------------------------");

        //public static in IndexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indicie do primeiro valor 3: {0}", indice1);
        Console.WriteLine("--------------------------------------------------");

        //public static in LastIndexOf(array, valor);
        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indicie do último valor 3: {0}", indice2);
        Console.WriteLine("--------------------------------------------------");

        //public static void Reverse(array);
        Array.Reverse(vetor1);
        Console.WriteLine("Reverse: ");
        foreach (int n in vetor1){
           Console.WriteLine(n); 
        }

        //public void SetValue(Object valor, long pos);
        vetor2.SetValue(99, 0);
        for (int i=0; i<vetor2.Length; i++){
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor2: ");
        foreach (int n in vetor2){
          Console.WriteLine(n);  
        }
        // public static void Sort(array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach (int n in vetor1){
          Console.WriteLine(n);  
        }
        Console.WriteLine("Vetor2");
        foreach (int n in vetor2){
          Console.WriteLine(n);  
        }
        Console.WriteLine("Vetor3");
        foreach (int n in vetor3){
          Console.WriteLine(n);  
        }
    }
}
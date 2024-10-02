using System;
class Aula05{
    
    static void Main(){
       int res = (10+5)*2; //atribução =, soma +, multiplicação *,parenteses(tem precedencia)
       //AND  && / E se todas forem verdadeiras serão verdadeiras
       //OR | / OU falso se todas forem falsas
       bool res1=(5>7)&(10<5); // relacionais = <, >, <=, >=, !=
       int num=10;
       num++; //num +=1; -=, *=, /=

       Console.WriteLine(res1);
    }
}
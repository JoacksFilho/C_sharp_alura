//Se listarmos todos os números naturais abaixo de 10 que são múltiplos de 3 ou 5, obtemos 3, 5, 6 e 9. A soma desses múltiplos é 23.
//Elabore um método que retorne a soma de todos os múltiplos de 3 ou 5 abaixo do número passado. Além disso, se o número for negativo, retorne 0.
//Nota: Se o número for múltiplo de 3 e 5, conte-o apenas uma vez.



using System;

class Programa
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Digite um número: "); 
        int numero = int.Parse(Console.ReadLine());

        
        int somaMultiplos = 0;

      

        for (int i = 0; i < numero; i++)
       {    

            if(numero < 0)
            {
                Console.WriteLine("0");// como que usa o return no c#?
            
            }
          
            else if (i % 3 == 0 || i % 5 == 0)
           {
               somaMultiplos += i;
             
            }
       }  
           Console.WriteLine("A soma dos números multiplos de 3 ou 5 é " + somaMultiplos);    
 }
}

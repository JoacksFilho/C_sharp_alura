using System;

class Desafio
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Digite um número: "); 
        int numero = int.Parse(Console.ReadLine());

        
        int somaMultiplos = 0;

        for (int i = 0; i < numero; i+=i)
       {    
            if(numero < 0)
            {
                Console.WriteLine(0);
            }
            if (i % 3 == 0 || i % 5 == 0)
           {
               somaMultiplos += i;
            }
       }  
       Console.WriteLine("A soma dos números multiplos de 3 ou 5 é " + somaMultiplos);     
 }
}

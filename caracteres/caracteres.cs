using System;

class caracteres
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - caracteres e textos");

        char letra = 'a'; // função char armazena 1 caracter. Usa aspas simmples
        // entende o caracter como um numero (tabela ASCII) - Armazena até 16bits

        letra = (char)65; //casting - converter para um tipo char

        letra = (char)(89+1);

        string primeiraFrase = "Alura - cursos de tecnologia ";
       // string vazia = ""; // podemos armazenar uma string vazia, char não é possível.

        string cursos = @"Cursos disponíveis: 
         - Python 
         - Go
         - C# 
         - Java";
         // @ comando que possibilita uma listagem. 

        Console.WriteLine(letra);
        Console.WriteLine(primeiraFrase + 2022);

        Console.WriteLine(cursos);


    }

}
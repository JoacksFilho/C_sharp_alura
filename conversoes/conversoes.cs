using System;

class Conversoes
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        
        int salarioInteiro;
        //salarioInteiro = salario// não é possivel converter uma var dessa forma
        salarioInteiro = (int)salario;
        Console.WriteLine(salario);

        long x;// consegue armazenar numeros grandes.(64bits)
        x = 200000000000;
        Console.WriteLine(x);
        short y; // numeros pequenos... Limite menor que int
        y = 1500; 
        Console.WriteLine(y);
        float altura = 1.79f; // maior precisão que double
        //Pode ser codificado tudo em uma linha.
        Console.WriteLine(altura); 
    }
}
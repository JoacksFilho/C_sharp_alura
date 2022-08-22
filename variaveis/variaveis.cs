using System;

//class variaveis
//{
   // static void Main(string[] args)
  //  {
       // Console.WriteLine("Projeto 2 - Criando Variáveis");//semelhante ao print. Faz uma quebra de linha
        //difente de usar so o write

       // int idadeUsuario; // padrao camelcase
        //idadeUsuario = 30-2;// ordem de precedencia segue a mesma ordem aritmética
        //idadeUsuario = 5*4 + 8;

        //Console.WriteLine("Minha idade é " + idadeUsuario);
        //Console.WriteLine("Tecle enter para fechar");

        //Console.ReadLine();   

//    }
//}

class Pontoflutuante
{
    static void Main(string[] arg)
    {
        double salario;
        salario = 2500.50;

        salario = 3000;

        double idade;
        idade = 7/5; // resultado fica 1, perde as info depois da virgula
        idade = 7.0/5; // Agora ele considera todo parte da divisão.

        Console.WriteLine("Meu salário é " + salario);
        Console.WriteLine(idade);
    }


}



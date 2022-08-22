using System;

//class Programa
//{
  //  static void Main(string[] args)
    //{
      //  Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

        //int idade = 30;
        //int idadeLara = idade;

        //Console.WriteLine(idadeLara); 

        //idade = 25;

    //}

//}

class Programa
{
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 7 - condicionais");


      int idadeJoao = 16;
      int qtd_pessoas = 2;

      if(idadeJoao >=18)
      {
        Console.WriteLine("Pode entrar na festa!");
      }  
      else
      {
            if (qtd_pessoas > 1)
            {
                Console.WriteLine("Está acompanhado. Pode entrar na festa!");
            }
            else
            {
                Console.WriteLine("Não pode entrar na festa!");
            }
            
      } 

    }
}
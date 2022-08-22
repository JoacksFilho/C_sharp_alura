//class Programa
//{
  //  static void Main(string[] args)
    //{
      //  Console.WriteLine("Executando projeto 8 - condicionais-var-boleanas");

        //int idadeJoao = 16;
        //int qtdPessoas = 2;
        // var logicas tbm pode armazenar valor
        //bool acompanhado = qtdPessoas > 1;
        



        //if (idadeJoao >= 18 || acompanhado) //qtdPessoas > 1)

        // operador logico or = || em c#
        // operador logico and = && em c#
        
        //{
          //  Console.WriteLine("Pode entrar!");
        //}  
        //else
        //{
          //  Console.WriteLine("Não pode entrar!");
        //}  
    //}
//}


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 9 - escopo");

        int idadeJoao = 16;
        int qtdPessoas = 2;
        // var logicas tbm pode armazenar valor
        bool acompanhado = qtdPessoas > 1;
        
        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
           // variaveis dentro de um if - existe somente nas chaves. Diferente do python.
           //Escopo local de uma condicional. 
        }
        else
        {
            textoAdicional = "João não está acompanhado!";
        
        }

        if (idadeJoao >= 18 || acompanhado) //qtdPessoas > 1)

        // operador logico or = || em c#
        // operador logico and = && em c#
        
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }  
        else
        
            Console.WriteLine("Não pode entrar!");
            // codigos else com apenas 1 linha, não precisam de chaveamento. 
    }
}

class Imposto
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if(salario <= 2800)
        {
            Console.WriteLine(" IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;");

        }
        else if(salario >=2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("o IR é de 15% e pode deduzir R$ 350;");
        }
        else if (salario >= 3751.01 && salario <= 4664.0)

        {
            Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636.");
        }
    }
}
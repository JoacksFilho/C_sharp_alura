//class Programa
//{
  //  static void Main(string[] arg)
    //{
      //  Console.WriteLine("Executando projeto 10 - laços repeticao");

        //double investimento = 1000;

        // rendimento de 0.5%(0.005) ao mes

        //int mes = 1;
    
        //while(mes <= 12)
        //{
         //   investimento = investimento + (investimento * 0.005);
           // Console.WriteLine("No mês " + mes + " você tem " + investimento);
            //mes += 1;
        //}
        
        
        //Console.WriteLine();
    //}
//}


// Usando o laço for

//class Programa
//{
  //  static void Main(string[] arg)
    //{
      //  Console.WriteLine("Executando projeto 11 - laços repeticao");

        //double investimento = 1000;

        // rendimento de 0.5%(0.005) ao mes

        
        //for (int mes = 1; mes <= 12; mes ++)   
         //{
           // investimento = investimento *= 1.005;
            //Console.WriteLine("No mês " + mes + " você tem " + investimento);
        //}
        
    //}


//}




class Programa
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Executando projeto 12 - laços repeticao - investimento a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        // rendimento de 0.5%(0.005) ao mes

        
        for (int anos = 1; anos <= 5; anos ++)   
        // variavel iniciadora , laço, variavel contadora.
         {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
           
        }
        
         Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);
    }


}

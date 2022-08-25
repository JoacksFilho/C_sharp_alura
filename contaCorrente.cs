
using bytebank.titular;

namespace bytebank
{
    public class ContaCorrente
    { 
        public Cliente Titular { get; set; }
        //propriedade autoimplementada

        private string _conta;
        public string conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }



        private int _agencia;
        public int agencia { 
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _agencia = value;
                }
            }
        } 
        
        public string nome_agencia { get; set; }
        private double saldo;

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                    return;
                saldo = value;
            }

        }

        public bool Sacar(double valor)
            // metodo sacar retorna um valor... 
            // logo usa return
        {
            if (saldo < valor)
                return false;

            if(valor < 0)
                return false;

            else
                saldo = saldo - valor;
                return true;
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
            // tipo void não retorna valor(só executa).
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
        //public void Exibir_dados()
        //{
        //    Console.WriteLine("Titular: " + titular.nome);
        //    Console.WriteLine("Agência: " + agencia);
        //    Console.WriteLine("Conta: " + conta);
        //    Console.WriteLine("Nome da agência: " + nome_agencia);
        //    Console.WriteLine("Saldo: " + saldo); 
        //}

        //public void SetSaldo(double valor)// set coloca valor no obj
        //{
        //    if (valor < 0)
        //        return;// retorna 0 padrão

        //    saldo = valor;
        //}

        //public double GetSaldo() //get pega o valor do obj
        //{
        //    return saldo;
        //}

      
        public ContaCorrente(int agencia, string conta)
        //Metodo construtor implicito (podemos passar parâmetro para 
        // preencher os atributos da classe.
        {
            _agencia = agencia;
            _conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }
        // static especifica que é uma propriedade estatica da classe.

    }   

        
}
using bytebank;
using bytebank.titular;

Console.WriteLine("Bem vindo ao banco ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "joacks filho";
//conta1.conta = "462-6";
//conta1.agencia = 1234;
//conta1.nome_agencia = "agência central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Lara Santello";
//conta2.conta = "123-4";
//conta2.agencia = 5678;
//conta2.nome_agencia = "Agência central";
//conta2.saldo = 100;


// se não tiver os atributos (mostra valor padrão - default).
// valor padrao para strings é vazio, numericos é 0 e bool é false


//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número agência: " + conta1.agencia);
//Console.WriteLine("Nome da agência: " + conta1.nome_agencia);   
//Console.WriteLine("Saldo R$: " + conta1.saldo);

//double saldo = 100;
//double saldo2 = conta1.saldo;// tipagem por valor (pega o valor do saldo do obj)

//Console.WriteLine(saldo == saldo2);

//conta1 = conta2;// Agora as duas variáveis apontam para o mesmo endereço de memoria.

//Console.WriteLine(conta1 == conta2); //tipo de referencia (referencias diferentes na memoria)

//Console.WriteLine("Saldo da Lara pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Joacks pre-transferência: " + conta1.saldo);

//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso! " + transferencia);
//Console.WriteLine("Saldo da Lara pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Joacks pós-transferência: " + conta1.saldo);

//conta1.Exibir_dados();

//Cliente cliente = new Cliente();

//cliente.nome = "Joacks Filho";
//cliente.cpf = "442.167.598-90";
//cliente.profissao = "Programador";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "joacks filho";
//conta3.titular.cpf = "442.167.598-90";
//conta3.titular.profissao = "programador";
//conta3.conta = "462-6";
//conta3.agencia = 1234;
//conta3.nome_agencia = "Agência central";
//conta3.saldo = 120.50;

//Console.WriteLine(conta3.titular.nome);

//if (conta3.titular == null)
//    Console.WriteLine("O campo titular está nulo");

////conta3.Exibir_dados();  


//Cliente sarah = new Cliente();
//sarah.nome = "Sarah Silva";

//ContaCorrente conta4 = new ContaCorrente(1234, "462-6");
//conta4.Saldo = 100;
//conta4.Titular = sarah;



//Console.WriteLine(conta4.Titular.nome);
//Console.WriteLine("Saldo: "+ conta4.Saldo);
//Console.WriteLine(conta4.agencia);
//Console.WriteLine(conta4.conta);

ContaCorrente conta5 = new ContaCorrente(456, "462-6");

ContaCorrente conta6 = new ContaCorrente(789, "12538-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey(); 


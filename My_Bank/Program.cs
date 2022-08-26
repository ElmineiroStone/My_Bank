using My_Bank.Funcionarios;
using My_Bank.Utilitario;

Console.WriteLine("Boas Vindas ao MyBank");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
Funcionario pedro = new Funcionario("16274839571");
pedro.Nome = "João";
pedro.Salario = 2000;
Console.WriteLine("Total de funcionarios: "+Funcionario.totaDeFuncionarios);

Diretor paulo = new Diretor("26378193782");
paulo.Nome = "Paulo Henrique";
paulo.Salario = 5000;
Console.WriteLine("Total de funcionarios: " + Funcionario.totaDeFuncionarios);

Funcionario andre = new Diretor("271845367928");
andre.Nome = "André";
andre.Salario = 3000;
Console.WriteLine("Total de funcionarios: " + Funcionario.totaDeFuncionarios);

Console.WriteLine("bonificação: "+pedro.getBonificacao());
Console.WriteLine("bonificação: " +paulo.getBonificacao());

gerenciador.Registrar(pedro);
gerenciador.Registrar(paulo);

Console.WriteLine("Total de bonificações: " + gerenciador.getBonificacao());

Console.ReadKey();
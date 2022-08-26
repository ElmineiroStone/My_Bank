using My_Bank.Funcionarios;
using My_Bank.Utilitario;

Console.WriteLine("Boas Vindas ao MyBank");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
Funcionario pedro = new Funcionario("16274839571", 2000);
pedro.Nome = "João";
Console.WriteLine("Total de funcionarios: "+Funcionario.totaDeFuncionarios);

Diretor paulo = new Diretor("26378193782", 5000);
paulo.Nome = "Paulo Henrique";
Console.WriteLine("Total de funcionarios: " + Funcionario.totaDeFuncionarios);

Funcionario andre = new Diretor("271845367928", 3000);
andre.Nome = "André";
Console.WriteLine("Total de funcionarios: " + Funcionario.totaDeFuncionarios);

Console.WriteLine("Bonificação: "+pedro.getBonificacao());
Console.WriteLine("Bonificação: " +paulo.getBonificacao());
Console.WriteLine("Bonificação: " + andre.getBonificacao());

gerenciador.Registrar(pedro);
gerenciador.Registrar(paulo);
gerenciador.Registrar(andre);

Console.WriteLine("Total de bonificações: " + gerenciador.getBonificacao());
Console.WriteLine("Total de bonificações: " + Funcionario.totaDeFuncionarios);

andre.AumentarSalario();
Console.WriteLine("Novo Salario do André: "+andre.Salario);

pedro.AumentarSalario();
Console.WriteLine("Novo Salario do Pedro: " + pedro.Salario);

Console.ReadKey();
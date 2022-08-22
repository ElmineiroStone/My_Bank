using My_Bank.Funcionarios;

Console.WriteLine("Boas Vindas ao MyBank");

Funcionario pedro = new Funcionario();
pedro.Nome = "João";
pedro.Cpf = "26173727289";
pedro.Salario = 2000;

Console.WriteLine("Nome: "+ pedro.Nome);
Console.WriteLine("CPF: "+ pedro.Cpf);
Console.WriteLine("Salario: "+ pedro.Salario);

Diretor paulo = new Diretor();
paulo.Nome = "Paulo Henrique";
paulo.Cpf = "16273849938";
paulo.Salario = 3000;

Console.WriteLine("bonificação: "+pedro.getBonificacao());
Console.WriteLine("bonificação: " +paulo.getBonificacao());
Console.ReadKey();
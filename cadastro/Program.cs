using System;
using System.Globalization;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa:");
            Console.WriteLine("Digite o nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite os dados da segunda pessoa:");
            Console.WriteLine("Digite o Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Primeira pessoa" + p1.Nome, "tem" + p1.Idade + " de idade");
            Console.WriteLine("Segunda pessoa" + p2.Nome, "tem" + p2.Idade + " de idade");



            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " é o mais velho");
            }
            else
            {
                Console.WriteLine(p2.Nome + " é o mais velho");
            }

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite o nome do funcionario 1");
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do funcionario 2");
            Console.WriteLine("Nome:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Priemiro funcionario: " + f1.Nome + "Salário: " + f1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Segundo funcionario: " + f2.Nome + "Salário: " + f2.Salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Média de salário: " + media.ToString("F2", CultureInfo.InvariantCulture));

            if(f1.Salario > f2.Salario)
            {
                Console.WriteLine("O Salário maior é do(a): " + f1.Nome);
            }
            else
            {
                Console.WriteLine("O salário maior é do(a): " + f2.Nome);
            }


        }
}
}

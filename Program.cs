using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Lista 05 - DateTime e Switch ===");
        Console.WriteLine();
        
        // Menu principal
        MostrarMenu();
    }
    
    static void MostrarMenu()
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("Escolha um exercício:");
            Console.WriteLine("1 - Data Atual");
            Console.WriteLine("2 - Idade");
            Console.WriteLine("3 - Dia da Semana");
            Console.WriteLine("4 - Mês");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            
            string opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    Exercicio1_DataAtual();
                    break;
                case "2":
                    Exercicio2_Idade();
                    break;
                case "3":
                    Exercicio3_DiaDaSemana();
                    break;
                case "4":
                    Exercicio4_Mes();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Até logo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine();
        }
    }
    
    static void Exercicio1_DataAtual()
    {
        Console.WriteLine("--- Exercício 1: Data Atual ---");
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Data e Hora: {agora}");
        Console.WriteLine($"Apenas a Data: {agora:dd/MM/yyyy}");
        Console.WriteLine($"Apenas a Hora: {agora:HH:mm:ss}");
    }
    
    static void Exercicio2_Idade()
    {
        Console.WriteLine("--- Exercício 2: Calcular Idade ---");
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
        {
            int idade = CalcularIdade(dataNascimento);
            Console.WriteLine($"Você tem {idade} anos.");
        }
        else
        {
            Console.WriteLine("Data inválida!");
        }
    }
    
    static int CalcularIdade(DateTime dataNascimento)
    {
        int idade = DateTime.Now.Year - dataNascimento.Year;
        if (DateTime.Now < dataNascimento.AddYears(idade))
            idade--;
        return idade;
    }
    
    static void Exercicio3_DiaDaSemana()
    {
        Console.WriteLine("--- Exercício 3: Dia da Semana ---");
        Console.Write("Digite uma data (dd/MM/yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            string dia = data.DayOfWeek switch
            {
                DayOfWeek.Monday => "Segunda-feira",
                DayOfWeek.Tuesday => "Terça-feira",
                DayOfWeek.Wednesday => "Quarta-feira",
                DayOfWeek.Thursday => "Quinta-feira",
                DayOfWeek.Friday => "Sexta-feira",
                DayOfWeek.Saturday => "Sábado",
                DayOfWeek.Sunday => "Domingo",
                _ => "Desconhecido"
            };
            Console.WriteLine($"O dia {data:dd/MM/yyyy} foi um(a) {dia}");
        }
        else
        {
            Console.WriteLine("Data inválida!");
        }
    }
    
    static void Exercicio4_Mes()
    {
        Console.WriteLine("--- Exercício 4: Mês ---");
        Console.Write("Digite uma data (dd/MM/yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            string mes = data.Month switch
            {
                1 => "Janeiro",
                2 => "Fevereiro",
                3 => "Março",
                4 => "Abril",
                5 => "Maio",
                6 => "Junho",
                7 => "Julho",
                8 => "Agosto",
                9 => "Setembro",
                10 => "Outubro",
                11 => "Novembro",
                12 => "Dezembro",
                _ => "Mês inválido"
            };
            Console.WriteLine($"O mês da data {data:dd/MM/yyyy} é {mes}");
        }
        else
        {
            Console.WriteLine("Data inválida!");
        }
    }
}

using System.Globalization;

namespace AT.Parte2;

public class Exercicio4
{
    public void ManipDatas()
    {
        Console.Write("Digite sua data de nascimento (ex.: 01/07/2000): ");
        string data = Console.ReadLine()!;
        DateTime hoje = DateTime.Today;

        if (DateTime.TryParseExact(data, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataNascimento))
        {
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            proximoAniversario = proximoAniversario < hoje ? proximoAniversario.AddYears(1) : proximoAniversario;
         
            int diasRestantes = (proximoAniversario - hoje).Days;
            if (diasRestantes <= 7)
            {
                Console.WriteLine("Seu aniversário está logo aí!");
            }

            Console.WriteLine($"Faltam {diasRestantes} dia(s) para seu aniversário!");
        }
        else
        {
            Console.WriteLine("Data inválida! Tente novamente.");
        }
    }
}
namespace AT.Parte2;

using System.Globalization;
using System;

public class Exercicio5
{
    public void TempoRestante()
    {
        Console.Write("Digite a data atual (dd/MM/yyyy): ");
        string dataAtualEntrada = Console.ReadLine()!;

        DateTime dataFormatura = new DateTime(2026, 12, 15);

        if (DateTime.TryParseExact(dataAtualEntrada, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataAtual))
        {
            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }
            else
            {
                int anos = dataFormatura.Year - dataAtual.Year;
                int meses = dataFormatura.Month - dataAtual.Month;
                int dias = dataFormatura.Day - dataAtual.Day;

                if (dias < 0)
                {
                    meses--;
                    dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
                }
                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");

                if (anos == 0 && meses < 6)
                {
                    Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                }
            }
        }
        else
        {
            Console.WriteLine("Data inválida! Tente novamente.");
        }
    }
}
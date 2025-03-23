using AT.Parte2;
using AT.Parte3;
using AT.Parte4;
using AT.Parte5;

namespace AT;

class Program
{
    static void Main(string[] args)
    {
        //Exercício1
        Console.WriteLine("Olá, meu nome é Gustavo!");
        Console.WriteLine("Nasci em 29/12/1999 e estou apredendo C#!");
        
        
        //---------------------------------------------------------------------------------------------------------
        // Exercícios 2 - 12
        while (true)
        {
            Console.WriteLine("Fundamentos de Desenvolvimento com C# Assessment!");
            Console.Clear();
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1. Exercício 1");
            Console.WriteLine("2. Exercício 2");
            Console.WriteLine("3. Exercício 3");
            Console.WriteLine("4. Exercício 4");
            Console.WriteLine("5. Exercício 5");
            Console.WriteLine("6. Exercício 6");
            Console.WriteLine("7. Exercício 7");
            Console.WriteLine("8. Exercício 8");
            Console.WriteLine("9. Exercício 9");
            Console.WriteLine("10. Exercício 10");
            Console.WriteLine("11. Exercício 11");
            Console.WriteLine("12. Exercício 12");

            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 2:
                    Exercicio2 exercicio2 = new();
                    exercicio2.ManipulacaoString();
                    break;
                case 3:
                    Exercicio3 exercicio3 = new();
                    exercicio3.CalcOpMat();
                    break;
                case 4:
                    Exercicio4 exercicio4 = new();
                    exercicio4.ManipDatas();
                    break;
                case 5:
                    Exercicio5 exercicio5 = new();
                    exercicio5.TempoRestante();
                    break;
                case 6:
                    Exercicio6 exercicio6 = new();
                    exercicio6.CadastroAlunos();
                    break;
                case 7:
                    Exercicio7 exercicio7 = new();
                    exercicio7.BancoDigital();
                    break;
                case 8:
                    Exercicio8 exercicio8 = new();
                    exercicio8.CadastroFunc();
                    break;
                case 9:
                    Exercicio9 exercicio9 = new();
                    exercicio9.ControleEstoque();
                    break;
                case 10:
                    Exercicio10 exercicio10 = new();
                    exercicio10.JogoAdivinha();
                    break;
                case 11:
                    Exercicio11 exercicio11 = new();
                    exercicio11.ManipArquivosCa();
                    break;
                case 12:
                    Exercicio12 exercicio12 = new();
                    exercicio12.ManipArquivosHerPol();
                    break;
                
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
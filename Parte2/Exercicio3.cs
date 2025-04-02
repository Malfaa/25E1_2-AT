namespace AT.Parte2;

public class Exercicio3
{
    public void CalcOpMat()
    {
        Console.Write("Digite um número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma opção: ");

        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        int escolha = Convert.ToInt32(Console.ReadLine());
        
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Resultado: " + Somar(num1, num2));
                break;
            case 2:
                Console.WriteLine("Resultado: " + Subtrair(num1, num2));
                break;
            case 3:
                Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                break;
            case 4:
                Console.WriteLine("Resultado: " + Dividir(num1, num2));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    private double Somar(double num1, double num2)
    {
        return num1+num2;
    }
    private double Subtrair(double num1, double num2)
    {
        return num1-num2;
    }
    private double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }
    private double Dividir(double num1, double num2)
    {
        double result = 0;
        if(num2 == 0 || num1 == 0)
        {
            Console.WriteLine("Não é possível fazer divisão por 0!");
        }
        else
        {
           result = num1/num2;
        }
        return result;
    }
}
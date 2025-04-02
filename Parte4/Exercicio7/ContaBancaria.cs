namespace AT.Parte4.Exercicio7;

public class ContaBancaria
{
    public string Titular;
    private double Saldo;
	
    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }
	
    public void Depositar(double valor)
    {
        if(valor < 0)
        {
            Console.WriteLine("O valor do depósito deve ser positivo!");
        }else
        {
            Saldo+=valor;
            Console.WriteLine($"Depósito de R${valor}, realizado com sucesso!");
        }
    }
    public void Sacar(double valor)
    {
        if(Saldo < valor)
        {
            Console.WriteLine($"Tentativa de saque: R${valor}");
            Console.WriteLine("Saldo insuficiente para realizar o saque");
        }else
        {
            Saldo-=valor;
            Console.WriteLine($"Saque de R${valor}, realizado com sucesso!");
        }
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo atual: R${Saldo}");
    }
}
namespace AT.Parte4.Exercicio8;

public class Funcionario
{
    string Nome;
    string Cargo;
    double SalarioBase;
    public Funcionario(string nome, string cargo, double salarioBase)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}\nCargo: {Cargo}\nSalario: R${SalarioBase}");
    }
}
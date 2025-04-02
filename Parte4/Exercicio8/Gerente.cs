namespace AT.Parte4.Exercicio8;

public class Gerente : Funcionario
{ 
    public Gerente(string nome,string cargo, double salarioBase): base(nome, cargo, salarioBase * 1.20)
    {
    }
}
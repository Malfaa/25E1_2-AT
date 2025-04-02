namespace AT.Parte3;

public class Aluno
{
    string Nome;
    string Matricula;
    string Curso;
    double Media;
	
    public Aluno(string nome, string matricula, string curso, double media)
    {
        Nome = nome;
        Matricula = matricula;
        Curso = curso;
        Media = media;
    }
	
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}\nMatrícula: {Matricula}\nCurso: {Curso}\nMédia de Notas: {Media}");
    }
	
    public string VerificarAprovacao()
    {
        if(Media >= 7)
        {
            return "Aprovado";
        }
        return "Reprovado";
    }
}
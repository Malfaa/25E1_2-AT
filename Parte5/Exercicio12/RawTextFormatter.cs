namespace AT.Parte5.Exercicio12;

public class RawTextFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("\nLista de Contatos:");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
        }
    }
}
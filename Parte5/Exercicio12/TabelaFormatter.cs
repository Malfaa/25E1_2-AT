namespace AT.Parte5.Exercicio12;

public class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("\n---------------------------------------------------------------------");
        Console.WriteLine("| Nome                 | Telefone       | Email                     |");
        Console.WriteLine("---------------------------------------------------------------------");
            
        foreach (var contato in contatos)
        {
            Console.WriteLine($"| {contato.Nome} | {contato.Telefone} | {contato.Email} |");
        }
            
        Console.WriteLine("---------------------------------------------------------------------");
    }
}
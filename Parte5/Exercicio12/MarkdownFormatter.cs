namespace AT.Parte5.Exercicio12;


public class MarkdownFormatter : ContatoFormatter
{

    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos");

        foreach (var contato in contatos)
        {
            Console.WriteLine($"- **Nome:**  {contato.Nome}\n- 📞 Telefone: {contato.Telefone}\n- 📧 Email: {contato.Email}\n");
        }
    }
}
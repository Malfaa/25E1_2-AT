namespace AT.Parte5.Exercicio12;

public class Exercicio12
{
    // ------------------- ALTERAR O PATH ---------------------
    private const string Path = @"/home/marufa/Documents/contatos.txt";
    // ------------------- ALTERAR O PATH ---------------------
    
    public void ManipArquivosHerPol()
    {
        while (true)
        {
            Console.WriteLine("=== Gerenciador de Contatos ===\n");
            Console.WriteLine("1 - Adicionar novo contato\n");
            Console.WriteLine("2 - Listar contatos cadastrados\n");
            Console.WriteLine("3 - Sair\n");
            Console.Write("Escolha uma opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    CadastroContato();
                    break;
                case 2:
                    ListaContatos();
                    break;
                case 3:
                    return;
            }
        }
    }

    private string AdicionarContato()
    {
        bool isVerificar;
        string nome;
        string telefone;
        string email;
        do
        {
            try
            {
                Console.Write("\nNome: ");
                nome = Console.ReadLine()!;
                Console.Write("Telefone(ex.: 21 99999-9999): ");
                telefone = Console.ReadLine()!.Replace("(", "").Replace(")", "");
                Console.Write("E-mail: ");
                email = Console.ReadLine()!;

                isVerificar = true;
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        } while (!isVerificar);

        return ($"{nome},{telefone},{email}");
        //output -> João Silva,21 99999-9999,joao@email.com
    }

    private void CadastroContato()
    {
        try
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine(AdicionarContato());
                sw.Close();
            }
            Console.WriteLine("\nContato cadastrado com sucesso!");
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
    }
    private void ListaContatos()
    {
        Console.WriteLine("Em qual formato deseja exibir os contatos?");
        Console.WriteLine("1. Markdown");
        Console.WriteLine("2. Tabela");
        Console.WriteLine("3. Texto Puro");
        Console.Write("Escolha: ");
        int escolha = Convert.ToInt32(Console.ReadLine());
        try
        {
            var contatos = new List<Contato>();
            using (StreamReader sr = new StreamReader(Path))
            {
                string linha;
                while ((linha = sr.ReadLine()!) != null)
                {
                    var dados = linha.Split(',');
                    if (dados.Length == 3)
                    {
                        contatos.Add(new Contato(dados[0], dados[1], dados[2]));
                    }
                }
                sr.Close();
            }

            ContatoFormatter formatter;
            switch (escolha)
            {
                case 1:
                    formatter = new MarkdownFormatter();
                    break;
                case 2:
                    formatter = new TabelaFormatter();
                    break;
                case 3:
                    formatter = new RawTextFormatter();
                    break;
                default:
                    throw new InvalidOperationException("Opção de formatação inválida");
            }
            
            formatter.ExibirContatos(contatos);
        }
        catch(Exception err)
        {
            Console.WriteLine("Nenhum contato cadastrado.");
        }
    }
}
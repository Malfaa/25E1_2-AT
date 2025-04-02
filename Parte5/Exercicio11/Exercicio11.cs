namespace AT.Parte5.Exercicio11;

public class Exercicio11
{
    // ------------------- ALTERAR O PATH ---------------------
    private const string Path = "/home/marufa/Documents/contatos.txt";
    // ------------------- ALTERAR O PATH ---------------------
    
    public void ManipArquivosCa()
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

    private void ExibirDadosContatos(string[] contato)
    {
        int indiceEspaco = contato[1].IndexOf(" ", StringComparison.Ordinal);
        string telefoneFormatado =
            "(" + contato[1].Substring(0, indiceEspaco) + ")" + contato[1].Substring(indiceEspaco);
        Console.WriteLine($"Nome: {contato[0]} | Telefone: {telefoneFormatado} | Email: {contato[2]}");
        //Nome: João Silva | Telefone: (21) 99999-9999 | Email: joao@email.com
    }

    private void ListaContatos()
    {
        Console.WriteLine("\nContatos cadastrados:");
        try
        {
            if (File.Exists(Path))
            {
                StreamReader sr = new StreamReader(Path);
                string linha;
                while ((linha = sr.ReadLine()!) is not null)
                {
                    string[] dados = linha.Split(",", StringSplitOptions.TrimEntries);
                    ExibirDadosContatos(dados);
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
    }
}
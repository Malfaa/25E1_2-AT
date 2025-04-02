namespace AT.Parte5.Exercicio9;

public class Exercicio9
{
    // ------------------- ALTERAR O PATH ---------------------
    private const string Path = @"/home/marufa/Documents/estoque.txt";
    // ------------------- ALTERAR O PATH ---------------------
    
    public void ControleEstoque()
    {
        while (true)
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Digite uma opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    InserirProdutos();
                    break;
                case 2:
                    ListarProdutos();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    private string AdicionarProduto()
    {
        try
        {
            Console.Write("Qual o produto? ");
            string nome = Console.ReadLine()!;
                    
            Console.Write("Qual é a quantidade? ");
            string quantidade = Console.ReadLine()!;		
                    
            Console.Write("Qual é o preço unitário? ");
            string preco = Console.ReadLine()!;
            
            return ($"{nome},{quantidade},{preco}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void InserirProdutos()
    {
        Console.Write("Quantos produtos deseja inserir? ");
        int qntdProdutos;
        
        bool isVerificar = false;
        do
        {
            qntdProdutos = Convert.ToInt32(Console.ReadLine());
            
            if(qntdProdutos > 5)
            {
                Console.WriteLine("Limite de produtos atingido! Tente novamente.");
            }else if(qntdProdutos < 1)
            {
                Console.WriteLine("Não é possível quantidade de produtos negativo!  Tente novamente.");
            }
            else
            {
                isVerificar = true;
            }
        } while (!isVerificar);
        
        string[] lista = new string[qntdProdutos];
        
        for(int i = 0; i < qntdProdutos; i++)
        {
            lista[i] = AdicionarProduto();
        }
        Console.WriteLine("Produtos Adicionados!");
        
        try
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                for (int i = 0; i < qntdProdutos; i++)
                {
                    sw.WriteLine(lista[i]);
                }
                sw.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    private void ListarProdutos()
    {
        StreamReader sr = new StreamReader(Path);
        string linha;
        while ((linha = sr.ReadLine()!) is not null)
        {
            string[] dados = linha.Split(",", StringSplitOptions.TrimEntries);
            ExibirDadosProdutos(dados);
        }
        sr.Close();
    }

    private void ExibirDadosProdutos(string[] paramProdutos)
    {
        Console.WriteLine($"Produto: {paramProdutos[0]} | Quantidade: {paramProdutos[1]} | Preço: R${paramProdutos[2]}");
    }
}
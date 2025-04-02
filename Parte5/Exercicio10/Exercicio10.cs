namespace AT.Parte5.Exercicio10;

public class Exercicio10
{
    public void JogoAdivinha()
    {
        Console.WriteLine("Tente adivinhar o número!\nEscolha um número entre 1 e 50!");
        int contagem = 0;
        Random random = new Random();
        int numAleatorio = random.Next(1, 51);
        bool isGanhou = false;
        int numero;
        
        do
        {
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero == numAleatorio)
                {
                    isGanhou = true;
                    break;
                }
                if(numero < 1 || numero > 50)
                {
                    throw new Exception("Número inválido");
                }
                Console.WriteLine("Número errado! Tente novamente.");
                contagem++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }while(contagem < 5);

        if(isGanhou)
        {
            Console.WriteLine("Parabéns! Você acertou!");
        }
        else
        {
            Console.WriteLine("Poxa! Você perdeu");
        }

    }
}
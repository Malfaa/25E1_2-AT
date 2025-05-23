using System.Text;
using System.Text.RegularExpressions;
   
namespace AT.Parte2;
   
public class Exercicio2
{
    public void ManipulacaoString()
    {
        Console.Write("Escreva seu nome: ");
        string nome = Console.ReadLine()!;
   
        string[] alfabetoMa =
        [
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
            "W", "X", "Y", "Z"
        ]; 
        string[] alfabetoMi =
        ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", 
            "v", "w", "x", "y", "z"
        ]; 
   
        string[] novoNome = new string[nome.Length]; 
        int index = 0;
        foreach (var i in nome)
        {
            if (i == ' ') 
            {
                novoNome[index] = " ";
                index++;
                continue; 
            }
            string ignoraAcento = i.ToString().Normalize(NormalizationForm.FormD);
            Regex regex = new Regex("[^a-zA-Z]");
            ignoraAcento = regex.Replace(ignoraAcento, "");
               
            // Verifica letras maiusculas
            int novoIndexMa = Array.IndexOf(alfabetoMa, ignoraAcento);
            if (novoIndexMa >= 0)
            {
                novoNome[index] = alfabetoMa[(novoIndexMa + 2) % alfabetoMa.Length];
                index++;
                continue;
            }
   
            // Verifica letras minúsculas
            int novoIndexMi = Array.IndexOf(alfabetoMi, ignoraAcento);
            if (novoIndexMi >= 0)
            {
                novoNome[index] = alfabetoMi[(novoIndexMi + 2) % alfabetoMi.Length];
                index++;
            }
        }
           
        Console.WriteLine(string.Join("", novoNome));
    }
}
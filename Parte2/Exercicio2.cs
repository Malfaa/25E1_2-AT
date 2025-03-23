using System.Text;
using System.Text.RegularExpressions;
   
namespace AT.Parte2;
   
public class Exercicio2
{
    public void ManipulacaoString()
    {
        Console.WriteLine("Escreva seu nome: ");
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
        int index = 0; //Auxiliar para o índex do novoNome
        // int indexLista=0;//Auxiliar para o índex do array em loop.
        foreach (var i in nome)
        {
            if (i == ' ') 
            {
                novoNome[index] = " "; // Mantém o espaço
                index++;
                continue; // Pula para o próximo caractere
            }
            string iToString = i.ToString().Normalize(NormalizationForm.FormD); //Ignorando acentuação
            Regex regex = new Regex("[^a-zA-Z]");
            iToString = regex.Replace(iToString, "");
               
            int novoIndexMa = Array.IndexOf(alfabetoMa, iToString);
   
            if (novoIndexMa >= 0)
            {
                novoNome[index] = alfabetoMa[(novoIndexMa + 2) % alfabetoMa.Length]; // Calcula o novo índice
                index++;
                continue; // Pula para o próximo caractere
            }
   
            // Verifica letras minúsculas
            int novoIndexMi = Array.IndexOf(alfabetoMi, iToString);
            if (novoIndexMi >= 0)
            {
                novoNome[index] = alfabetoMi[(novoIndexMi + 2) % alfabetoMi.Length]; // Calcula o novo índice
                index++;
            }
        }
           
        Console.WriteLine(string.Join("", novoNome));
    }
}
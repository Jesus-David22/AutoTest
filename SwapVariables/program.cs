using System;
using System.IO;

namespace SwapVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê os valores de A e B do arquivo data.txt
            string[] lines = File.ReadAllLines("data.txt");
            int a = int.Parse(lines[0]);
            int b = int.Parse(lines[1]);

            // Imprime os valores originais
            Console.WriteLine($"Valor Original de A: {a}");
            Console.WriteLine($"Valor Original de B: {b}");

            // Troca os valores
            (a, b) = (b, a);

            // Imprime os valores finais
            Console.WriteLine($"Valor Final de A: {a}");
            Console.WriteLine($"Valor Final de B: {b}");

            // Salva os valores finais no arquivo output.txt
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("Valor Origem de A | Valor Origem de B | Valor Final de A | Valor Final de B");
                writer.WriteLine($"{lines[0]}                  {lines[1]}                  {a}                  {b}");
            }
        }
    }
}

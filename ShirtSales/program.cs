using System;
using System.IO;

namespace shirtSales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê os dados do arquivo data.txt
            string[] lines = File.ReadAllLines("data.txt");
            string clientName = lines[0];
            int quantity = int.Parse(lines[1]);

            // Calcula o preço total
            int pricePerShirt = quantity < 12 ? 1083 : 1000;
            int totalPrice = quantity * pricePerShirt;

            // Salva os resultados no arquivo output.txt
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("Nome do Cliente | Qtd Comprada | Valor Aplicado | Valor Venda");
                writer.WriteLine($"{clientName}          {quantity}           {pricePerShirt}           {totalPrice}");
            }
        }
    }
}

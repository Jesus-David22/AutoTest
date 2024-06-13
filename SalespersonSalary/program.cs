using System;
using System.IO;

namespace SalespersonSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê os dados do arquivo data.txt
            string[] lines = File.ReadAllLines("data.txt");
            string name = lines[0];
            int itemsSold = int.Parse(lines[1]);
            double totalSales = double.Parse(lines[2]);
            double fixedSalary = double.Parse(lines[3]);
            double commissionPerItem = double.Parse(lines[4]);

            // Calcula a comissão e o salário final
            double commission = itemsSold * commissionPerItem;
            double finalSalary = fixedSalary + commission + (totalSales * 0.05);

            // Salva os resultados no arquivo output.txt
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("Vendedor    | Qtd Itens | Valor Vendido | Valor Comissão | Salário | Salário Final");
                writer.WriteLine($"{name}    {itemsSold}        {totalSales}         {commission}          {fixedSalary}     {finalSalary}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using ListaObjetos.classes;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(01, "Café", 2.5f));
            produtos.Add(new Produto(02, "Misto Quente", 5f));
            produtos.Add(new Produto(03, "Coxinha", 1.98f));
            produtos.Add(new Produto(04, "Risole", 3.5f));

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Item código {item.Codigo} Nome {item.Nome} Preço {item.Preco}");
            }
            
        }
    }
}

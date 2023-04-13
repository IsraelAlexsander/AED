using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Aux;

            Hashtable meuHashtable = new Hashtable();

            meuHashtable.Add("123", "João");
            meuHashtable.Add("456", "Denise");
            meuHashtable.Add("789", "Pedro");
            meuHashtable.Add("111", "Maria");
            meuHashtable.Add("222", "José");


            Console.WriteLine("Os seguintes dados foram inseridos na tabela\n");
            foreach (DictionaryEntry Elemento in meuHashtable)
            {
                Console.WriteLine($"{Elemento.Key} - {Elemento.Value}"); 
            }

            Console.ReadKey();

            Console.Clear();


            Console.WriteLine("As seguintes chaves foram inseridos na tabela\n");
            foreach (string Chave in meuHashtable.Keys)
            {
                Console.WriteLine($"{Chave}");
            }

            Console.WriteLine("\nOs seguintes valores foram inseridos na tabela\n");
            foreach (string Values in meuHashtable.Values)
            {
                Console.WriteLine($"{Values}");
            }

            Console.ReadKey();

            Console.Clear();

            Console.Write("Digite uma chave: ");
            Aux = Console.ReadLine();

            if (meuHashtable.ContainsKey(Aux))
            {
                Console.WriteLine($"\nEssa chave existe com valor {meuHashtable[Aux]}");
            }
            else
            {
                Console.WriteLine($"\nEssa chave não existe na tabela!");
            }

            Console.ReadKey();

            meuHashtable.Remove(Aux);
        }
    }
}

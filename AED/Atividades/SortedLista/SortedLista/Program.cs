using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Não Generica
            //SortedList MinhaSortedList = new SortedList();

            //MinhaSortedList.Add(123, "Israel");
            //MinhaSortedList.Add(456, "Alexsander");
            //MinhaSortedList.Add(789, "Vilela");
            //MinhaSortedList.Add(121, "Andrade");

            //mostra(MinhaSortedList);
            #endregion

            SortedList<string, string> minhaSorted = new SortedList<string, string>();

            minhaSorted.Add("txt", "Notepad");
            minhaSorted.Add("bmp", "Paint");
            minhaSorted.Add("doc", "Word");
            minhaSorted.Add("xis", "Exel");
            minhaSorted.Add("ppt", "PowerPoint");

            mostra(minhaSorted);

            try
            {
                minhaSorted.Add("txt", "WinWord");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nA chave \"txt\" já existe");
                Console.WriteLine($"Atualmente a chave \"txt\" está associada a \"{minhaSorted["txt"]}\"\n");
            }

            Console.ReadKey();

            minhaSorted["txt"] = "WinWord";

            mostra(minhaSorted);

        }

        static void mostra(SortedList<string, string> X)
        {
            Console.Clear();

            Console.WriteLine("Chave\tValor");
            Console.WriteLine("-----\t-----");

            foreach (KeyValuePair<string, string> x in X)
            {
                Console.WriteLine($"{x.Key}\t{x.Value}");
            }

            Console.WriteLine($"\nExistem {X.Count} Elementos na Estrutura");

            Console.ReadKey();
        }

    }
}

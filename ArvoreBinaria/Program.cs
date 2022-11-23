using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MMM/yyyy HH:mm") + " | Desenvolvido por SenhorN");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("pressione enter para continuar...");
            Console.ReadKey();
            Console.Clear(); //limpatela

            Console.WriteLine(DateTime.Now.ToString("dd/MMM/yyyy HH:mm") + " | Árvore Binária");
            Console.WriteLine(); //Pulo de uma linha 

            tree ArvBinaria = new tree();

            ///Inserção dos conjuntos
            Console.WriteLine("Inserção do conjunto A");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //vetor A 
            int[] A = { 21, 16, 28, 9, 18, 23, 31, 7, 12, 17, 20 };

            for (int i = 0; i < A.Length; i++)
            {
                ArvBinaria.Inserir(A[i]);
            }

            ArvBinaria.criar();
            Console.WriteLine();


            Console.WriteLine("-------------------------------------------------------------------------------------");
            
            Console.WriteLine();//Pulo de uma linha 
            Console.WriteLine();//Pulo de uma linha 
            
            Console.WriteLine("Inserção do conjunto Z");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //vetor Z
            int[] Z = { 31, 28, 23, 21, 20, 18, 17, 16, 12, 9, 7 };

            for (int i = 0; i < Z.Length; i++)
            {
                ArvBinaria.Inserir(Z[i]);
            }
            Console.ReadKey();
        }
    }
}

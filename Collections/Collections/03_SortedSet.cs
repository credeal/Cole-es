using System;
using System.Collections.Generic;

namespace Collections
{
    partial class Program
    {
        static void Interseccao()
        {
            ////intersecção dos conjuntos - IntersectWith
            ISet<string> Alunos1 = new HashSet<string>()
            {
               "A","B","C",
            };

            ISet<string> Alunos2 = new HashSet<string>()
            {
                "A","D","E"
            };

            //intersecção dos conjuntos - IntersectWith
            Alunos1.IntersectWith(Alunos2);

            //somente em um ou outro conjunto - SymmetricExceptWith
            Alunos1.SymmetricExceptWith(Alunos2);

            //união de conjuntos - UnionWith
            Alunos1.UnionWith(Alunos2);

        }

        static void SetEquals()
        {
            //conjuntos contêm os mesmos elementos
            ISet<string> Alunos1 = new HashSet<string>()
            {
               "A","B","C",
            };

            ISet<string> Alunos2 = new HashSet<string>()
            {
                "A","B","C"
            };

            Console.WriteLine($"O conjunto A: [{String.Join(",", Alunos1)}] contem os mesmos elementos do conjunto B: [{String.Join(",", Alunos2)}] ? {Alunos1.SetEquals(Alunos2)}");

        }

        static void Superconjunto()
        {
            // se nosso conjunto é um superconjunto de outro, ou seja, se contém algum outro:
            ISet<string> Alunos1 = new HashSet<string>()
            {
               "A","B","C","D","F","G"
            };

            ISet<string> Alunos2 = new HashSet<string>()
            {
                "A","B","C"
            };

            Console.WriteLine($"O conjunto A: [{String.Join(",", Alunos1)}] é superconjuntoO do conjunto B: [{String.Join(",", Alunos2)}] ? {Alunos1.IsSupersetOf(Alunos2)}");

        }

        static void Subconjunto()
        {
            //Ele compara os valores de um conjunto com o outro 
            ISet<string> Alunos1 = new HashSet<string>()
            {
                "A","B","C",
            };

            //Faremos em seguida um método para descobrirmos se um conjunto é subconjunto de outro:
            ISet<string> Alunos2 = new HashSet<string>()
            {
                "A","B","C"
            };

            

            Console.WriteLine($"O conjunto A: [{String.Join(",",Alunos1)}] é subconjunto do conjunto B: [{String.Join(",",Alunos2)}] ? {Alunos1.IsSubsetOf(Alunos2)}");

        }

        static void UtilizandoSortedSet()
        {
            //Com o sortedSet é uma Lista Ordenada
            ISet<string> alunos = new SortedSet<string>(new Comparador())//Comparando os valores se são maisculos ou não
            {
                "Vanessa Tonini", "Ana Losnak", "Rafael Nercessian","Priscila Stuani"
            };

            //adicionar: Rafael Rollo
            alunos.Add("Rafael Rollo");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            //adicionar: FABIO GUSHIKEN
            alunos.Add("FABIO GUSHIKEN"); //<--------

            Imprimir(alunos);
        }

        static void UtilizandoHashSet()
        {
            //É UMA LISTA NÃO ORDENADA
            //O ISET não aceita valores duplicados , neste caso ele não vai aceitar dois fabios Gushiken
            //Porem se um for maiusculo e outro minusculo ele acaba aceitando
            ISet<string> alunos = new HashSet<string>()
            {
                "Vanessa Tonini", "Ana Losnak", "Rafael Nercessian","Priscila Stuani"
            };

            //adicionar: Rafael Rollo
            alunos.Add("Rafael Rollo");
            //adicionar: Fabio Gushiken
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            //adicionar: FABIO GUSHIKEN
            alunos.Add("FABIO GUSHIKEN"); //<--------

            Imprimir(alunos);
            
        }

        private static void Imprimir(ISet<string> Alunos )
        {
            Console.WriteLine($"Total: {Alunos.Count}");

            foreach (var Aluno in Alunos)
            {
                Console.WriteLine(Aluno);
            }

        }
    }

    internal class Comparador : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
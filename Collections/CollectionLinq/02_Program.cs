using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionLinq {
    partial class Program
    {


        static void ConsultasComLinq()
        {
            List<Mes> meses = new List<Mes> {
                 //1 ° Trimêstre
                 new Mes("Janeiro", 31),
                 new Mes("Fevereiro", 28),
                 new Mes("Março", 31),
                 //2 ° Trimêstre
                 new Mes("Abril", 30),
                 new Mes("Maio", 31),
                 new Mes("Junho", 30),
                 //3 ° Trimêstre
                 new Mes("Julho", 31),
                 new Mes("Agosto", 31),
                 new Mes("Setembro", 30),
                 //4 ° Trimêstre
                 new Mes("Outubro", 31),
                 new Mes("Novembro", 30),
                 new Mes("Dezembro", 31)
            };

            //Pegar o primeiro Trimestre
            var consulta1 = meses.Take(3); //pegando os 3 primeiros item da lista

            System.Console.WriteLine("Pegando o 1º Trimestre: ");
            Imprimir(consulta1);

            //Pegar os meses depois do primeiro Trimestre
            var consulta2 = meses.Skip(3);
            System.Console.WriteLine("Pegando os valore depois do 1º Trimestre: ");
            Imprimir(consulta2);

            //Pegar os meses do terceiro Trimestre
            var consulta3 = meses.Skip(6).Take(3);
            System.Console.WriteLine("Pegando o 3º Trimêstre: ");
            Imprimir(consulta3);

            //Pegar os meses até que o mês comece com a letra 'S'
            //TAKEWHILE = PEGE ATE O NOME DO MES FOR DIFERENTE DE S
            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            System.Console.WriteLine("Pegar os mêses até que o mês comece com a Letra 'S':");
            Imprimir(consulta4);

            ////Pular os meses até que o mês comece com a letra 'S'
            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            System.Console.WriteLine("Pule até que o mês comece com a letra S: ");
            Imprimir(consulta5);

        }

        static void OperadoresConjuntos()
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            //Concater dois conjuntos - Repete valores iguais
            System.Console.Write("Concatenando: ");
            System.Console.WriteLine($"[{string.Join(" ",seq1)}] - [{string.Join(" ",seq2)}]");

            var consulta1 = seq1.Concat(seq2);
            Imprimir(consulta1);

            //Fazendo A união de dois conjuntos - Não ira repetir valores iguais
            Console.WriteLine("União de duas sequências");
            var consulta2 = seq1.Union(seq2);
            Imprimir(consulta2);

            //União de dois conjuntos com comparador
            Console.WriteLine("União de duas sequências com comparador");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            Imprimir(consulta3);

            //intersecção de dois conjuntos
            //Retorna os valores que pertecem em ambos os conjuntos
            Console.WriteLine("Intersecção de duas sequências");
            var consulta4 = seq1.Intersect(seq2, StringComparer.InvariantCultureIgnoreCase);
            Imprimir(consulta4);

            //Exceto
            // ele fará com que sejam isolados todos os elementos presentes na primeira sequência, 
            //e que não estão na segunda.
            Console.WriteLine("Exceto");
            var consulta5 = seq1.Except(seq2);
            Imprimir(consulta5);

            //Executaremos a aplicação e observaremos que serão impressos, somente, aqueles elementos pertencentes à sequência 1,
            //e que não estão na sequência 2.


        }

        private static void Imprimir(IEnumerable<string> meses)
        {
            System.Console.WriteLine($"Total: {meses.Count()}");
            foreach (var mes in meses)
                System.Console.WriteLine(mes.ToLower());

            System.Console.WriteLine();

        }

        private static void Imprimir(IEnumerable<Mes> meses)
        {
            foreach (var mes in meses)
                System.Console.WriteLine(mes.Nome.ToLower());
         
            System.Console.WriteLine();

        }
    }
}
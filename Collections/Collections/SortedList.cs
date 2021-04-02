using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    partial class Program
    {
       static void UtilizandoDictionary()
        {
            //Utilizando o Dictionary não temos controle da ordenação da nossa Coleção
            //Para isso é necessario utilzilar o AlunosList
            IDictionary<string, Aluno> Alunos = new Dictionary<string, Aluno>();
            

            //Ordem que foi Inserido os dados
            Alunos.Add("VT", new Aluno("Vanessa", 34672));
            Alunos.Add("AL", new Aluno("Ana", 5617));
            Alunos.Add("RN", new Aluno("Rafael", 17645));
            Alunos.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(Alunos);

            //Remover Ana
            Alunos.Remove("AL");

            //Inserir Marcelo
            //Ao adicionar o Marcelo não sabemos a onde ele sera inserido
            Alunos.Add("MO", new Aluno("Marcelo", 12345));

            System.Console.WriteLine();

            Imprimir(Alunos);

        }

       static void UtilizandoSortedList()
        {
            IDictionary<string, Aluno> Alunos = new SortedList<string, Aluno>();

            //Ordena pela KEY
            Alunos.Add("VT", new Aluno("Vanessa", 34672));
            Alunos.Add("AL", new Aluno("Ana", 5617));
            Alunos.Add("RN", new Aluno("Rafael", 17645));
            Alunos.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(Alunos);

            Alunos.Remove("AL");
            System.Console.WriteLine();

            //Apos inserir ele ordena novamente  nossa coleção
            Alunos.Add("MO", new Aluno("Marcelo", 12345));

            Imprimir(Alunos);
        }

       private static void Imprimir(IDictionary<string,Aluno> Alunos)
       {
            //Imprimindo...
            foreach (var Aluno in Alunos)
            {
                System.Console.WriteLine(Aluno);
            }
       }

        

    }
}
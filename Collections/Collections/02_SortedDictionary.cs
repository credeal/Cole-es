using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    partial class Program
    {
        static void UtilizandoSortedDictionary()
        {
            //SortedDictionary é semelhante com o SortedList
            //A diferença é que com o SortedDictornay ele faz a busca atráves de Nós em uma arvore binaria
            //Consequentemente mais rapido sua busca

            //Por isso, uma inserção ou remoção muito frequente de elementos, neste tipo de lista, 
            //é menos eficiente do que num SortedDictionary.

            //Entretanto, caso o objetivo seja criar uma coleção em que todos os elementos iniciais já estão definidos,
            //o mais indicado seria a SortedList

            IDictionary<string, Aluno> Alunos = new SortedDictionary<string, Aluno>();

            Alunos.Add("VT", new Aluno("Vanessa", 34672));
            Alunos.Add("AL", new Aluno("Ana", 5617));
            Alunos.Add("RN", new Aluno("Rafael", 17645));
            Alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in Alunos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
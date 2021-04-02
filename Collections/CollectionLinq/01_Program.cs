using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionLinq
{
    partial class Program
    {
        static void ComLinq()
        {
            List<Mes> meses = new List<Mes> {
                 new Mes("Janeiro", 31),
                 new Mes("Janeiro", 31),
                 new Mes("Fevereiro", 28),
                 new Mes("Março", 31),
                 new Mes("Abril", 30),
                 new Mes("Maio", 31),
                 new Mes("Junho", 30),
                 new Mes("Julho", 31),
                 new Mes("Agosto", 31),
                 new Mes("Setembro", 30),
                 new Mes("Outubro", 31),
                 new Mes("Novembro", 30),
                 new Mes("Dezembro", 31)
            };

            var consulta = meses.Where(m => m.Dias == 31)
                                .OrderBy(m => m.Nome).ToList();

            consulta.ForEach(c =>
            {
                Console.WriteLine(c);
            });
                                             
           
        }

        static void SemLinq()
        {
             List<Mes> meses = new List<Mes> { 
                 new Mes("Janeiro", 31),
                 new Mes("Janeiro", 31),
                 new Mes("Fevereiro", 28),
                 new Mes("Março", 31),
                 new Mes("Abril", 30),
                 new Mes("Maio", 31),
                 new Mes("Junho", 30),
                 new Mes("Julho", 31),
                 new Mes("Agosto", 31),
                 new Mes("Setembro", 30),
                 new Mes("Outubro", 31),
                 new Mes("Novembro", 30),
                 new Mes("Dezembro", 31)
            };

            meses.Sort();

            foreach (var mes in meses)
            {
                if(mes.Dias == 31)
                    Console.WriteLine(mes.Nome.ToUpper());
            }

        }
    }
}
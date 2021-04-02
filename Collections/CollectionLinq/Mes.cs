using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLinq
{
    public class Mes : IComparable
    {

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public int CompareTo(object obj)
        {
            var outroMes = obj as Mes;

            return Nome.CompareTo(outroMes.Nome);
        }

        public override string ToString()
        {
            return $"{Nome.ToUpper()} - {Dias}";
        }
    }
}

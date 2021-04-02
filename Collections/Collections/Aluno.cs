using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public override string ToString()
        {
            return $"{Nome} - {NumeroMatricula}";
        }
    }
}

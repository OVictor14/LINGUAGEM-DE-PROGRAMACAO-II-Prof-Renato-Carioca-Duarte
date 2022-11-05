using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Funcionario
    {
        string Nome;
        int Matricula;
        string CPF;

        public string SetNome(string Nome) { this.Nome = Nome; }

        public int SetMatricula(int Matricula) { this.Matricula = Matricula; }

        public string SetCPF(string CPF) { this.CPF = Nome; }


        public string GetNome() { return Nome; }

        public int GetMatricula() { return Matricula; }

        public string GetCPF() { return CPF; }


        public Funcionario(string Nome, int Matricula, string CPF)
        {
            this.Nome = Nome;

            this.Matricula = Matricula;

            this.CPF = CPF;
        }

        public void imprimeFuncionario() => Console.WriteLine(Nome + " " + Matricula + " " + CPF );
    }
}

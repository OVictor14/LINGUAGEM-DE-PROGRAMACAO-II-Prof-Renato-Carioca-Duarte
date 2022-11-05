using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Departamento
    {
        string Nome;
        ArrayList funcionarios = new ArrayList();

        public void adicionaFuncionario(Funcionario f) => funcionarios.Add(f);

        public void imprimeDepartamento()
        {
            foreach (Funcionario f in funcionarios) f.ImprimeFun();
        } 

        public Departamento(string Nome)=> this.Nome = Nome;
    }
}

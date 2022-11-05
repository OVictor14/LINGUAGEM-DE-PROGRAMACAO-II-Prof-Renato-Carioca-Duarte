using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento DpVendas = new Departamento("Vendas");

            Funcionario f1 = new Funcionario("Mat", 666, "696969696");
            Funcionario f2 = new Funcionario("Optimus Prime", 420, "22442244");

            DpVendas.adicionaFuncionario(f1);
            DpVendas.adicionaFuncionario(f2);
            DpVendas.imprimeDepartamento();
        }
    }
}

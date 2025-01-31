using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste.Na.Folha.De.Pagamento
{
    public class RepositorioFuncionario
    {
        private IList<Funcionario> funcionarios = new BindingList<Funcionario>();

        public void Inserir( Funcionario funcionario )
        {
            funcionarios.Add(funcionario);
        }

        public IList<Funcionario> ObterTodos ()
        {
            if( funcionarios.Count == 0)
            {
                foreach (var func in funcionarios)
                {
                    func.Salario = null;
                    func.Codigo = null;

                }
            }
            return funcionarios;
        }
    }
}

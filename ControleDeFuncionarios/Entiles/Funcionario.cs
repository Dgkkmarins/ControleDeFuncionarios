using ControleDeFuncionarios.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Entiles
{
    public class Funcionario
    {
        #region  Propriedades da entidade
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; } = DateTime.Now;
        public string Cpf { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public decimal Salario { get; set; } = 0;
        public Cargo cargo { get; set; } 


        #endregion
        #region Relacionamentos
        public Endereco Endereco { get; set; } = new();

        #endregion
    }
}
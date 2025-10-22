using ControleDeFuncionarios.Entiles;
using ControleDeFuncionarios.Enums;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Repositories
{///<sumary>   
    ///repositorio de banco de dados para a entidade de funcionario.
   /// </sumary>
    public class FuncionarioRepository
    {
        public void Inserir(Funcionario funcionario)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDFuncionarios;Integrated Security=True;";
           
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("Sp_inserir_funcionario", new
                {
                    @nome = funcionario.Nome,
                    @cpf = funcionario.Cpf,
                    @matricula = funcionario.Matricula,
                    @DATAADMISSAO = funcionario.DataAdmissao,
                    @salario = funcionario.Salario,
                    @Cargo = (int)funcionario.cargo,
                    @logradouro = funcionario.Endereco.Logradouro,
                    @numero = funcionario.Endereco.Numero,
                    @bairro = funcionario.Endereco.Bairro,
                    @localidade = funcionario.Endereco.Localidade,
                    @uf = funcionario.Endereco.Uf,
                    @cep = funcionario.Endereco.Cep,
                
                }, 
                commandType: CommandType.StoredProcedure
                );
            }

        }
    }
}

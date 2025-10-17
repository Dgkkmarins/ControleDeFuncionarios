using ControleDeFuncionarios.Entiles;
using ControleDeFuncionarios.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Controllers
{   ///<sumary>
    ///Controlador de Funcionarios
    ///</sumary>  
    public class FuncionarioController
        {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\nCadastro De Funcionario:\n");
                //Criando um objeto da classe Funcionario
                var funcionario = new Funcionario();
                Console.Write("Nome do Funcionario...:");
                funcionario.Nome=Console.ReadLine()?? string.Empty;
                Console.Write("Cpf...:");
                funcionario.Cpf=Console.ReadLine()?? string.Empty;
                Console.Write("Matricula...:");
                funcionario.Matricula = Console.ReadLine() ?? string.Empty;
                Console.Write("Data de Admissao...:");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Salario...:");
                funcionario.Salario = decimal.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("informe o Cep...");
                var cep= Console.ReadLine() ?? string.Empty;
                //criando um objeto da classe de serviço
                var viacepService=new ViaCepService();
                //consultando o endereço pelo CEP
                var endereco = viacepService.ObterEndereco(cep);
                //imprimindo o endereco no consolde (prompt)
                Console.WriteLine("\nEndereco Obtido:\n");
                Console.WriteLine(endereco);
                //Lendo os campos do endereço contido no Json retornado pelo ViaCep
                var json = JsonDocument.Parse(endereco);
                funcionario.Endereco.Logradouro = json.RootElement.GetProperty("logradouro").GetString() ?? string.Empty;
                funcionario.Endereco.Bairro = json.RootElement.GetProperty("bairro").GetString() ?? string.Empty;
                funcionario.Endereco.Localidade = json.RootElement.GetProperty("localidade").GetString() ?? string.Empty;
                funcionario.Endereco.Uf = json.RootElement.GetProperty("UF").GetString() ?? string.Empty;
                funcionario.Endereco.Cep = json.RootElement.GetProperty("Cep").GetString() ?? string.Empty;
                Console.WriteLine("\nInforme o numero do endereço:");
                funcionario.Endereco.Numero = Console.ReadLine() ?? string.Empty;
            }
            catch(Exception e)
            {
                Console.WriteLine($"\nfalha ao cadastrar funcionario: {e.Message}");
            }
        }
}
}

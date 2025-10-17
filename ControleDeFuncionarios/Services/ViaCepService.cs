using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Services
{  /// <summary>
    ///Classe de serviço para integração com a API ViaCep.
    /// </summary>
    public class ViaCepService
{
        public string ObterEndereco(string cep)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

                return response.Content.ReadAsStringAsync().Result;
            }   
        }
    }
}

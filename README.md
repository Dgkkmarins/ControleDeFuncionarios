# Controle de Funcionários

Projeto **Console C#** para cadastro e gerenciamento de funcionários, integrando consultas de endereço via CEP e persistência em banco de dados com Dapper.

---

## Descrição do Projeto

Este projeto permite que um usuário cadastre funcionários através de um console. O fluxo principal do sistema é o seguinte:

1. O usuário informa os dados do funcionário.
2. O `FuncionarioController` captura os dados digitados.
3. O sistema consulta o endereço do funcionário utilizando o **CEP** informado, através da classe `ViaCepService`, que faz integração com a [API ViaCep](https://viacep.com.br/).
4. Os dados do funcionário e do endereço são enviados para o `FuncionarioRepository`, que persiste as informações no banco de dados utilizando [Dapper](https://dapper-tutorial.net/).
5. A gravação é realizada através de uma **Stored Procedure** no SQL Server.

---

## Arquitetura do Projeto

O projeto segue uma arquitetura modular e clara, separando responsabilidades:

- **Controllers**
  - `FuncionarioController`: Captura dados do usuário e coordena os serviços.

- **Services**
  - `ViaCepService`: Consulta a API ViaCep para buscar endereço pelo CEP.

- **Repositories**
  - `FuncionarioRepository`: Persiste dados no banco usando Dapper e Stored Procedures.

- **Entities**
  - `Funcionario`: Representa os dados do funcionário.
  - `Endereco`: Representa os dados do endereço.

**Fluxo de dados:**

```
Usuário -> FuncionarioController -> ViaCepService -> FuncionarioRepository -> Banco de Dados
```

---

## Tecnologias Utilizadas

- [C# Console Application](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Dapper](https://dapper-tutorial.net/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [API ViaCep](https://viacep.com.br/)
- [Stored Procedures](https://learn.microsoft.com/pt-br/sql/relational-databases/stored-procedures/stored-procedures-database-engine)

---

## Como Executar

1. Clone o projeto:
```bash
git clone <URL_DO_REPOSITORIO>
```

2. Abra no Visual Studio ou VS Code.

3. Configure a string de conexão com o banco de dados no arquivo de configuração do projeto.

4. Execute o projeto em modo Console.

5. Siga as instruções na tela para cadastrar um funcionário.

---

## Estrutura de Pastas

```
/ControleFuncionarios
│
├─ Controllers
│  └─ FuncionarioController.cs
│
├─ Services
│  └─ ViaCepService.cs
│
├─ Repositories
│  └─ FuncionarioRepository.cs
│
├─ Models
│  ├─ Funcionario.cs
│  └─ Endereco.cs
│
└─ Program.cs
```

---

## Referências

- [Documentação Dapper](https://dapper-tutorial.net/)
- [API ViaCep](https://viacep.com.br/)
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [SQL Server Stored Procedures](https://learn.microsoft.com/pt-br/sql/relational-databases/stored-procedures/stored-procedures-database-engine)


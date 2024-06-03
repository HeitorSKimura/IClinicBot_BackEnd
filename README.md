# IClinicBot
### 🔗 -> [**Confira Tambem o Front-End**](https://github.com/VictorMMontanari/IClinicBot.git)
### 🔗 -> [**Confira Tambem o Chat-Bot**](https://github.com/FERNANDO-MATSUHASHI/IClinicBot-ChatBot.git)

## 🧾 Descrição:
Nosso Software tem como foco agilizar o atendimento em áreas da Saúde Hospitar e de Clinicas. 

## 📊 Diagrama UML - Class
![Alt text](https://github.com/HeitorSKimura/IClinicBot_BackEnd/blob/main/IClinicBot_UML_Class.png)

## 📌 Aplicativos Necessários:
Visual Studio - https://visualstudio.microsoft.com/pt-br/downloads/ (Comunidade)
<br/>
SDK 8 - https://dotnet.microsoft.com/pt-br/download/dotnet/8.0
> [!IMPORTANT]
> SDK 8.0.100 --> Visual Studio 17.7 / SDK 8.0.200 --> Visual Studio 17.8

### 🧰 Items Necessários Para o Visual Studio:
- ASP.NET e Desenvolvimento WEB
- Desenvolvimento para Desktop com .NET
- Processamento e Armazenamentos de Dados

## 😎 Para Clonar e Executar o Repositorio:
1. Clone o repositório: `git clone https://github.com/HeitorSKimura/IClinicBot_BackEnd.git`
2. Abra o projeto no Visual Studio.
3. Restaure as dependências: `dotnet restore`
4. Execute o aplicativo: `dotnet run` F5

## 😃 Para Criar e Executar o Banco de Dados:
### 01 - Para criação de um novo banco de dados
Ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes

### 02 - Dentro do console de pacotes canto superio Direito (Projeto Padrão:) selecionar ( IClinicBot.Infra.SqlServer ) e iniciar os seguintes comandos:
`PM> Add-Migration QualquerNome`
<br/>
`PM> Update-Database`

### 03 - Para Verificar o conteudo do Banco de Dados
Exibir -> Pesquisador de Projetos do SQL Server

### 04 - Selecione a pasta: 
SQL Server -> localdb -> Banco de Dados do Sistema -> IClinicBot -> Tabelas 

# 🚨 Atenção:
## Não esqueça de apagar a Migration em (Infra.SqlServer) e apagar o Banco de Dados Local em (Exibir -> Pesquisador de Projetos do SQL Server) após apagar os seguintes campos retomar os comandos do campo 02

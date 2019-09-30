1) Criar Projeto
- Tipo: Aplicativo WPF .NET Framwork
- Nome: RegistroPonto
- Nome da Solução: RegistroPonto
2) Criar Pastas no projeto
- DAL
- Models
- Views

3) Apagar MainWindows
- Criar em Views
  - Adicionar "Janela (WPF)" 
    - nome: frmJanelaPrincipal.
  - Corrigir o caminho em App.xaml
      - StartupUri="Views/frmJanelaPrincipal.xaml"

4) Criar Context em Models
- Context
  - Clique em: Models > CTRL+SHIFT+A > Visual C# > Dados > ADO.NET Entity Data Model
    - Nome: Context
    - Empty First Code model
    - Editar Context.cs
      - trocar: base("name=Context") -> base("name=BdRegistroPontoWPF")

5) Criar Janelas
- frmCadastroUsuario
- frmCargo
- frmRegistroPonto
- frmSobre

6) Adicionar Formulários
  frmCadastroUsuario
- frmCargo
- frmRegistroPonto
- frmSobre

7) Adicionar DAO
- UsuarioDAO
- PontoDAO
- CargoDAO

8) Habilitar Migrações
- Mudar em context.cs base("name=BdRegistroPontoWPF") para base("BdRegistroPontoWPF")
- Abrir Menu > Exibir > Outras Janelas > Console Gerenciador de Pacotes:
  - Executar: Enable-Migrations
  - Executar: add-migration inicio
  - Executar: update-database -Verbose











## Outros
	- Para instalar EntityFramework: Install-Package EntityFramework
	  - get-help entityframework -Verbose
	- Enable-Migrations -EnableAutomaticMigrations -Force
	- Add-Migration -Force <Nome>
	- drop table if exists __MigrationHistory
	
	- Get-Migrations
	
	- Views > SQL Server Object Browser (Gerenciador do banco de dados local)


## Referencias
- Install EF6 https://docs.microsoft.com/pt-br/ef/ef6/
  - Code First https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
- https://coding.abel.nu/2012/03/ef-migrations-command-reference/
- https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx
- https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/learn/lecture/11527674#overview
- https://www.devmedia.com.br/csharp-entity-framework-entendendo-o-funcionamento-do-model-first/29661
- Extra
  - https://docs.microsoft.com/pt-br/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
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

8) CRUDs (ponto, usuarios, cargo)
- Habilitar Migrações
- Mudar em context.cs base("name=BdRegistroPontoWPF") para base("BdRegistroPontoWPF")
- Abrir Menu > Exibir > Outras Janelas > Console Gerenciador de Pacotes:
- Adicionado Tabela TipoEntradaSaida - Populado ao executar: add-migration (ver Configuration.cs)
  - Executar: Enable-Migrations -EnableAutomaticMigrations -Force
  - Executar: add-migration inicio
  - Executar: update-database -Verbose
  - Executar(resetar o banco de dados - os dados): update-database -TargetMigration:0 -Force -Verbose

9) Atualizar BD
- update-database -TargetMigration:0 -Force -Verbose
- update-database -Verbose









## Outros
	- Para instalar EntityFramework: Install-Package EntityFramework
	  - get-help entityframework -Verbose
	- Enable-Migrations -EnableAutomaticMigrations -Force
	- Add-Migration -Force <Nome>
	- drop table if exists __MigrationHistory
	
	- Get-Migrations
	
	- Views > SQL Server Object Browser (Gerenciador do banco de dados local)


## Debug SQL
- Adicionar no arquivo App.config
```xml
<entityFramework>
  ...

    <interceptors> 
      <interceptor type="System.Data.Entity.Infrastructure.Interception.DatabaseLogger, EntityFramework"> 
        <parameters> 
          <parameter value="c:\temp\ef_log.txt"/> 
          <parameter value="true" type="System.Boolean"/> 
        </parameters> 
      </interceptor> 
    </interceptors>

    ...
</entityFramework>
```
- https://visualstudiomagazine.com/articles/2017/01/02/entity-framework-query-visual-studio.aspx

## Referências
- Install EF6 https://docs.microsoft.com/pt-br/ef/ef6/
  - Code First https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
- https://coding.abel.nu/2012/03/ef-migrations-command-reference/
- https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx
- https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/learn/lecture/11527674#overview
- https://www.devmedia.com.br/csharp-entity-framework-entendendo-o-funcionamento-do-model-first/29661
- SQL Collumn Types -  https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/sqlclient-for-ef-types
- Linq - https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/walkthrough-writing-queries-linq
- Link - Select Query https://www.learnentityframeworkcore.com/dbset/querying-data
- Datas Null - https://stackoverflow.com/questions/1833054/how-can-i-format-a-nullable-datetime-with-tostring

- Extra
  - https://docs.microsoft.com/pt-br/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
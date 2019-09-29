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
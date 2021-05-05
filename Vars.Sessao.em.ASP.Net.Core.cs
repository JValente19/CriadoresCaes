Vars de sessão em ASP .NET Core

 // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-5.0
 
 
No ficheiro Startup.cs, no método  public void ConfigureServices(IServiceCollection services)
adicionar:

      // uso de vars. de sessão
      services.AddDistributedMemoryCache();
      services.AddSession(options => {
         options.IdleTimeout = TimeSpan.FromSeconds(10);
         options.Cookie.HttpOnly = true;
         options.Cookie.IsEssential = true;
      });

e no método   public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
adicionar:
      
      // permitir o uso de vars. de sessão
      app.UseSession();
         
depois de  'app.UseRouting();'
e, antes de  'app.UseEndpoints(endpoints =>'


No controller
Criar uma variável sessão:  HttpContext.Session.SetInt32("NomeVarSessao", ValorAAtribuir);

Ler a variável de sessão:
   // testar se existe valor na var. sessão
   var leu = string.IsNullOrEmpty(HttpContext.Session.GetString("NomeVarSessao"));
   // ler valor
   var numIdFoto = HttpContext.Session.GetInt32("NomeVarSessao");
         
         
eventualmente, poderá ser contruída uma CONST para guardar o nome da variável de sessão:
    public const string SessionKeyNome = "NomeVarSessao";
         

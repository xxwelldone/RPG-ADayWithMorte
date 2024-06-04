using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ADayWithMorte.Core.Service.Sistema.Menu;
using ADayWithMorte.Core.Interface.IService.ISistem;

namespace ADayWithMorte.Main.Config
{
    internal class Program
    {
        //API ela vai mandar textos(POST) -> o texto vai ser transformado no modelo -> texto vai ser salvo
        //jogar:(GET) jogos disponiveis -> escolhe jogo -> pega textos do jogo -> le o jogo como deve ser lido
        // jogo pronto: .EXE
        
        static void Main(string[] args)
        {
            // Crie uma nova instância do ConfigurationBuilder
            var configurationBuilder = new ConfigurationBuilder();

            // Adicione (opcionalmente) um arquivo de configuração
            object value = configurationBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            // Construa a configuração
            var configuration = configurationBuilder.Build();

            // Crie o contêiner de serviço e configure suas dependências
            IServiceCollection services = new ServiceCollection();
            InjectionConfig.ConfigureServices(services, configuration);

            // Construa o provedor de serviços
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Agora você pode usar o serviceProvider para obter suas dependências
                // Por exemplo: var myService = serviceProvider.GetRequiredService<IMyService>();
                var menu = serviceProvider.GetRequiredService<IMenuInicial>();
                menu.DisplayMenu(true);
            }
        
        //engine de jogo (classe unica? injeção?)
        //necessario criar uma injeção de config

        //Banco de dados
        //var optionsBuilder = new DbContextOptionsBuilder<PostGreeContext>();
        //    optionsBuilder.UseNpgsql("SuaConnectionStringAqui");
        //    PostGreeContext context = new PostGreeContext(optionsBuilder.Options);
        //    UnitOfWork unitOfWork = new UnitOfWork(context);

        //    //config do console
        //    Console.OutputEncoding = Encoding.UTF8;

        //    ISoundSystem soundSystem = new SoundSystem();
        //    //IGameTimer gameTimer = new GameTimer();
        //    ISaveService saveService = new SaveService(unitOfWork);

        //    //pensar como chamar as musicas
        //    string musicIntro = @"..\..\..\..\ADayWithMorte.Shared\Sound\intro\heart_monitor.wav";

        //    MenuInicial menu = new MenuInicial(soundSystem, musicIntro, saveService);
        //    menu.DisplayMenu(true);

        //    //capitulos
        //    //posibilidade menu de lugares para ir, tornar o jogo sem um caminho especifico
        //    //não ha ordem porem items e uma ordem ajudam na historia
        //    //caixas e mecanicas devem estar em seu capitulo
        //    //a definição 

        //    //teste de mecanicas
        //    // TextBoxFormater text = new(soundSystem);
        //    //text.FormatAndPrintSkullBox("Morte: (rindo) \"Sim, sou Morte. E antes que você pergunte, não, você não está sonhando. Achei que esse seria um lugar interessante para te abordar. Afinal, quem não precisa de uma boa conversa quando acorda, não é?\"\n Você tenta processar a situação absurda enquanto Morte continua. \n Morte: Tenho uma proposta inusitada para você. Você parece ser uma pessoa especial. Que tal ser meu assistente por um dia? É uma experiência única, prometo.\n Conforme você fornece as informações, Morte acena com a cabeça, como se as peças do quebra-cabeça estivessem se encaixando. \"Interessante,\" ela murmura, \"esses detalhes são mais importantes do que você imagina.\"");
        //    //text.ChoiceOption("Opção 1: Tenho medo de perder as pessoas que amo. (Moral) \n Opção 2:Tenho medo do desconhecido (Harmônico)");
        //    //dice.throwDice();

        //    //será colocado dentro dos service dos capitulos? 
        //    //necessario pensar aplicabilidade no jogo, talvez com a cartomante?
        //    DiceSistem dice = new DiceSistem(soundSystem);

        //    //pensar como se chama o inventario no jogo
        //    //Inventario inventario = new Inventario(soundSystem, musicIntro, menu);
        //    //inventario.DisplayMenu(false);

        //    //entender como injetar o settings no MenuInicial e no Inventario
        //    MenuSettings menuSettighs = new MenuSettings(soundSystem, musicIntro, menu);
        //    menuSettighs.DisplayMenu(false);
        }
    }
}

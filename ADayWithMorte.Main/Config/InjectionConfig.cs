
//using Microsoft.EntityFrameworkCore;
using ADayWithMorte.Core.Interface.IService.ISistem;
using ADayWithMorte.Core.Interface.IService;
using ADayWithMorte.Core.Service.Sistema.Music;
using ADayWithMorte.Core.Service;
using ADayWithMorte.Infra.Context;
using ADayWithMorte.Shared.Sistema.Timer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Text;
using ADayWithMorte.Core.Service.Sistema.Menu;
using ADayWithMorte.Core.Interface.IUnitOfWork;
using ADayWithMorte.Infra.UOW;
using ADayWithMorte.Shared.Sistema.Menu;

namespace ADayWithMorte.Main.Config
{
    public static class InjectionConfig
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Configuração do console
            Console.OutputEncoding = Encoding.UTF8;
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<ISoundSystem, SoundSystem>();
            services.AddTransient<IGameTimer, GameTimer>();
            services.AddTransient<ISaveService, SaveService>();

            // Configuração de música
            string musicIntro = @"..\..\..\..\ADayWithMorte.Shared\Sound\intro\heart_monitor.wav";
            services.AddSingleton(musicIntro);

            // Configuração de menus
            services.AddTransient<IMenuSettings, MenuSettings>();
            services.AddSingleton<IMenuManager, MenuManager>();
            services.AddTransient<IMenuInventory, MenuInventory>();
            services.AddTransient<IMenuInicial, MenuInicial>();


            //banco de dados
            services.AddDbContext<PostGreeContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            //            return services;
        }

    }
}


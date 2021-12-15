
using ARINLAB.Services;
using ARINLAB.Services.ImageService;
using DAL.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;


namespace ARINLAB.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IEmailSender, MailKitEmailSender>();
            services.AddSingleton<IImageService, ImageService>();
            services.Configure<MailKitEmailSenderOptions>(options =>
            {
                options.Host_Address = "smtp.mail.ru";
                options.Host_Port = 465;
                options.Host_Username = "tazedowur@mail.ru";
                options.Host_Password = "tdta2020";
                options.Sender_EMail = "tazedowur@mail.ru";
                options.Sender_Name = "ARINLANG";
            });

            services.AddScoped<IWordServices, WordServices>();
            services.AddScoped<IDictionaryService, DictionaryService>();
            services.AddScoped<FileServices>();
            services.AddScoped<IWordClauseService, WordClauseService>();
            services.AddScoped<ILanguageService, LanguageService>();
            //Add Scoped Services


            return services;
        }
    }
}

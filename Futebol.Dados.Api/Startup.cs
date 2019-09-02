using Futebol.Dados.Api.Models;
using Futebol.Dados.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Futebol.Dados.Api.Repositories;
using AutoMapper;
using Futebol.Dados.Api.DTOs;

namespace Futebol.Dados.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<FutebolDatabaseSettings>(
                Configuration.GetSection(nameof(FutebolDatabaseSettings)));

            services.AddSingleton<IFutebolDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<FutebolDatabaseSettings>>().Value);

            services.AddScoped<JogoService>();
            services.AddScoped<JogoRepository>();
            services.AddSingleton(ConfigureMapperConfiguration());

            services.AddMvc()
                .AddJsonOptions(opt => opt.UseMemberCasing())
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        IMapper ConfigureMapperConfiguration()
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Jogo, JogoDTO>()
                    .ForMember(dest => dest.TimeMandante, opt => opt.MapFrom(src => src.Times.Casa))
                    .ForMember(dest => dest.TimeVisitante, opt => opt.MapFrom(src => src.Times.Fora))
                    .ForMember(dest => dest.GolsMandante, opt => opt.MapFrom(src => src.Gols.Casa))
                    .ForMember(dest => dest.GolsVisitante, opt => opt.MapFrom(src => src.Gols.Fora))
                    .ForMember(dest => dest.Estadio, opt => opt.MapFrom(src => src.Local.Estadio))
                    .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Local.Cidade))
                    .ForMember(dest => dest.UF, opt => opt.MapFrom(src => src.Local.Estado));
            });

            return config.CreateMapper();
        }
    }
}

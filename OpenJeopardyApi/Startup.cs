using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OpenJeopardy.Core.Application.BoardDesign;
using OpenJeopardy.Core.Application.BoardDesign.Commands;
using OpenJeopardy.Core.Domain.Boards;
using OpenJeopardy.Infrastructure;
using OpenJeopardy.Infrastructure.Repositories;
using Serilog;

namespace OpenJeopardyApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<OpenJeopardyContext>(options => options.UseInMemoryDatabase());
            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IBoardEditingService, BoardEditingService>();
            services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(CreateNewBoardCommand).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Trace()
                .CreateLogger();
        }
    }
}

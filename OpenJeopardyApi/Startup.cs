using System;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenJeopardy.Core.Application.Services.BoardDesign;
using OpenJeopardy.Core.Domain.BoardDesign.Handlers;
using OpenJeopardy.Core.Domain.Boards;
using OpenJeopardy.Core.Domain.Users;
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
            services.AddDbContext<OpenJeopardyContext>(options => options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IBoardEditingService, BoardEditingService>();
            services.AddMediatR(typeof(CreateNewBoardHandler).Assembly);
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

        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Objects;

namespace objects { 
public class program {

        public static void Main(String[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            ////////////////////////////////////////////////////////

            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            WebApplication app = builder.Build();

            //WebApplication app = WebApplication.CreateBuilder(args).Build();
            //

            if (app.Environment.IsDevelopment())
            {
                app.MapGet("/", () => "Мы в режиме разработки");
                app.MapGet("/hi", () => "Мы приветствуем тебя");
            }
            else
            {
                app.MapGet("/", () => "Hello World!");
            }

            app.Run();
            //app.Start();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
           return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }

    }

}

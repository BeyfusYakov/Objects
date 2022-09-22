using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Objects;

namespace objects { 
public class program {

        public static void Main(String[] args)
        {
            WebHost.CreateDefaultBuilder(args)
           .UseStartup<Startup>()
           .Build()
           .Run();
            #region еще один вариант загрузки через mapget

            ////////////////////////////////////////////////////////

            //WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            //WebApplication app = builder.Build();

            //WebApplication app = WebApplication.CreateBuilder(args).Build();
            //

            // if (app.Environment.IsDevelopment())
            // {
            //     app.MapGet("/", () => "Стартовая страница");
            //     app.MapGet("/hi_edit", () => "Страница приветствия");
            // }
            // else
            // {
            //     app.MapGet("/", () => "Hello World!");
            // }

            // app.Run();
            //app.Start();

            #endregion
        }



    }

}

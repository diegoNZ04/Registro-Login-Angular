
// imports
    using Microsoft.EntityFrameworkCore;
    using Aspangular.Infrastructure.Db;
    using Microsoft.AspNetCore.SpaServices.AngularCli;

// builder
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // config database
        builder.Services.AddDbContext<DbContexto>(options =>
        {
            options.UseMySql(
                builder.Configuration.GetConnectionString("mysql"),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
            );
        });

    // config angular in production
        builder.Services.AddSpaStaticFiles(configuration =>
        {
            configuration.RootPath = "ClientApp/dist";
        });

// app
    var app = builder.Build();

    // config frontend
        app.UseSpa(spa =>
        {
            spa.Options.SourcePath = "ClientApp";
            spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");

            if (app.Environment.IsDevelopment())
            {
                spa.UseAngularCliServer(npmScript: "start");
            }
        });

    // others
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();

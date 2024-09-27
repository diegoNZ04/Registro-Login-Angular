
// imports
    using Microsoft.EntityFrameworkCore;
    using Aspangular.Infrastructure.Db;
    using Microsoft.AspNetCore.SpaServices.AngularCli;

// builder
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();
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

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    
    // config frontend
    app.UseCors(options =>
    options.WithOrigins("http://localhost:4200")
    .AllowAnyMethod()
    .AllowAnyHeader());

    // others
    app.MapControllers();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.Run();

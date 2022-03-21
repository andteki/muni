global using Microsoft.EntityFrameworkCore;
global using App01.Data;
// using Microsoft.Extensions.PlatformAbstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<DataContext>(options => 
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    // var path = PlatformServices.Default.Application.ApplicationBasePath;
    // options.UseSqlite("Filename=" + Path.Combine(path, "database.db"));
    options.UseSqlite(connectionString);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

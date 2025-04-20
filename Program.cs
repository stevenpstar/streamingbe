using Microsoft.EntityFrameworkCore;
using StreamingBE.Data;
using StreamingBE.Services;

var builder = WebApplication.CreateBuilder(args);

// DB Setup
//

// Add services to the container.

builder.Services.AddControllers();
Console.WriteLine("Setting up Database Connection");
builder.Services.AddDbContextPool<StreamingdevContext>(opt =>
  opt.UseNpgsql(builder.Configuration.GetConnectionString("DevDB")));

builder.Services.AddOpenApi();
builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name:"FrontEndUI", policy =>
    {
        policy.WithOrigins("http://localhost:4200/").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("FrontEndUI");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();

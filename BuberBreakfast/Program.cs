using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSingleton<IBreakfastService,BreakfastService>();
}
var app = builder.Build();

// Configure the HTTP request pipeline.
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

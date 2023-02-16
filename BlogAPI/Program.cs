using BlogAPI;
using Data.InitialDB;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

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

try
{
    ////Add admin user to DB if not exists.
    await InitialDB.SeedUserAsync();
}
catch (Exception ex)
{
    ////Log exception
}

app.Run();

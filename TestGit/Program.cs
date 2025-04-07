var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
// New Code added in Master Branch

// New Code added for master branch from github directly

// New Code 2 added for master branch from github directly


app.MapControllers();

app.Run();

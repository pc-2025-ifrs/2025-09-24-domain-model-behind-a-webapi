<<<<<<< HEAD
using trabalho.Repositories;
=======
using Steam.Repositories;

>>>>>>> 488cb584a59ccb36626a202b4ff8fa521a0d1603
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

<<<<<<< HEAD
//add repositories 
builder.Services.AddSingleton<ICanalRepository, InMemoryCanalRepository>();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
builder.Services.AddSwagger();
builder.Services.AddEndPointsApiExplorer();
=======
// Add repositories (diz que a aplicação tem repositórios)
builder.Services.AddSingleton<IDeveloperRepository, InMemoryDeveloperRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
>>>>>>> 488cb584a59ccb36626a202b4ff8fa521a0d1603

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
<<<<<<< HEAD
    // app.MapOpenApi();
    app.MapSwagger();
    app.MapEndPointsApiExplorer();
=======
    app.UseSwagger();
    app.UseSwaggerUI();
>>>>>>> 488cb584a59ccb36626a202b4ff8fa521a0d1603
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

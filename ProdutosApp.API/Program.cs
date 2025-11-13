using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
///adicionando os servicos do swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Lear as configurações de origens mapeadas no appsetting.json
var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

//configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigins",
        policy => policy
            .WithOrigins(allowedOrigins!)//valores do appsettings.json
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

///Executando os servicos do swagger
app.UseSwagger();
app.UseSwaggerUI();

///executando os serviços do Scalar
app.MapScalarApiReference(s =>s.WithTheme(ScalarTheme.BluePlanet));

//configuração do CORS
app.UseCors("AllowOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();

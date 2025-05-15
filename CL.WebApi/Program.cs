
// Cria o builder da WebApplication para adicionar as dependências e configurar o pipeline de requisições.
var builder = WebApplication.CreateBuilder(args);



// Adição de serviços ao contêiner.
// Adição de Controller I Endpoints I Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adição de serviços de injeção de dependência
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

// Rodar a aplicação
app.Run();

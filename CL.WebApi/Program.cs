
// Cria o builder da WebApplication para adicionar as depend�ncias e configurar o pipeline de requisi��es.
var builder = WebApplication.CreateBuilder(args);



// Adi��o de servi�os ao cont�iner.
// Adi��o de Controller I Endpoints I Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adi��o de servi�os de inje��o de depend�ncia
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

// Rodar a aplica��o
app.Run();

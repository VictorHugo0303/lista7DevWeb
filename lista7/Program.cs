using lista7.Repository;
using lista7.Service;

var builder = WebApplication.CreateBuilder(args);

// Configurando a injeção de dependência
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IDisciplinaService, DisciplinaService>();
builder.Services.AddScoped<INotaAlunoService, NotaAlunoService>();

// Repositórios
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
builder.Services.AddScoped<INotaAlunoRepository, NotaAlunoRepository>();


var app = builder.Build();
app.Run();


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

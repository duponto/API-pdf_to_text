var builder = WebApplication.CreateBuilder(args);
var nomeCors = "_PoliticaCors";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: nomeCors,
        policy =>
        {
            policy.WithOrigins
            (
                "http://127.0.0.1:5500"
            );
            policy.AllowAnyHeader();
        });
});
var app = builder.Build();
app.UseCors(nomeCors);
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

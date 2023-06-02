using API_pdf_to_text.Repositories;
using API_pdf_to_text.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var nomeCors = "_PoliticaCors";

builder.Services.AddTransient<IPDFService, PDFService>();


builder.Services.AddControllers();
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

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

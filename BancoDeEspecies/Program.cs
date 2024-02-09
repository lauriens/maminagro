using BancoDeEspecies.Application.Extensions;
using BancoDeEspecies.DataAccess.Extensions;

var dev = "_dev";
var prod = "_prod";

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: dev,
        policy =>
        {
            policy.WithOrigins("http://localhost:5173", "https://localhost:5220")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(
            options => options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
        );


builder.Services.ConfigureDbContext(Configuration);
builder.Services.ConfigureRepositories();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UseCors(dev);
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

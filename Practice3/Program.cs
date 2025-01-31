using UPB.AppLogic.Managers;
using Serilog;
using UPB.Pratice3.Middlewares;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(builder.Configuration.GetSection("Logging").GetSection("FilePaths").GetSection("LogPath").Value)
    .CreateLogger();

Log.Information("Starting up");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<PatientManager>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandlerMiddleware();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

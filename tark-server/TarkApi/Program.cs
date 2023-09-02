using Microsoft.EntityFrameworkCore;
using TarkApi.DAL;
using TarkApi.Services.TicketService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<TarkDbContext>(options => 
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("TarkDbConnection"))
        .UseSnakeCaseNamingConvention() 
    );
builder.Services.AddScoped<ITicketService, TicketService>();

// idk if here CORS || TODO: add specific policy (URI or URL) for the CORS, ex. limit it to localhost:3000
// builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
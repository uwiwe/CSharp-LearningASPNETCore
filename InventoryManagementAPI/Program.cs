using InventoryManagementAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// NEW Add DbContext configuration here
builder.Services.AddDbContext<InventoryContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("InventoryDatabase"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("InventoryDatabase"))));

// Add other services to the container.
builder.Services.AddControllers();

// Swagger/OpenAPI configuration
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

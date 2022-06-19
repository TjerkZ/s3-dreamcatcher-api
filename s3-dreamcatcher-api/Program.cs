using Microsoft.EntityFrameworkCore;
using s3_dreamcatcher_api.dal;
using s3_dreamcatcher_api.abstraction;
using s3_dreamcatcher_api.logic.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DreamContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DreamContext"));
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IDreamDal, DreamDal>();
builder.Services.AddScoped<DreamManager, DreamManager>();


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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

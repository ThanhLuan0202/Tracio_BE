using Microsoft.EntityFrameworkCore;
using Tracio.Data;
using Tracio.Data.Data;
using Tracio.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TracioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TracioDB"),
        sqlOptions =>
        {
            sqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            sqlOptions.CommandTimeout(30); 
            sqlOptions.EnableRetryOnFailure(3);
        }));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRepository().AddServices();





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

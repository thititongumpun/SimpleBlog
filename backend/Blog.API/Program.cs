using Blog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

//private IConfiguration Configuration;

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Blog.API", Version = "v1" });
});

// builder.Services
//     .AddEntityFrameworkNpgsql()
//     .AddDbContext<BlogContext>(options =>
//         options.UseNgpsql(
//             Config
//         ));
//builder.Services
//    .AddEntityFrameworkNpgsql()
//    .AddDbContext<BlogContext>(options =>
//        options.UseNpgsql(
//            Configuration.GetConnectionString("BlogContext"),
//                o => o.MigrationsAssembly("Blog.API")
//                )
//        );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog.API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

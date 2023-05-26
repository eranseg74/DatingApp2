using API.Extensions;
using API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline. Order is important (after the builder.Build())!!!!
app.UseMiddleware<ExceptionMiddleware>();

app.UseCors(corsPolicyBuilder => corsPolicyBuilder.AllowAnyHeader().AllowAnyMethod()
    .WithOrigins("http://localhost:4200", "https://localhost:4200"));

// Middlewares
app.UseAuthentication(); //Do you have a token?
app.UseAuthorization(); //What are your priviliges in accordance with the token

app.MapControllers();

app.Run();

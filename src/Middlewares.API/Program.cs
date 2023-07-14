using Middlewares.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<CustomMiddleware>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware using IMiddleware Interface
app.UseMiddleware<CustomMiddleware>();
// Middleware 
app.UseMyMiddleware();
app.UseAuthorization();

app.MapControllers();

// Middlewares
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Primeiro middleware (antes)\n");
    await next();
    await context.Response.WriteAsync("Primeiro middleware (depois)\n");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Segundo middleware (antes)\n");
    await next();
    await context.Response.WriteAsync("Segundo middleware (depois)\n");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from 1st app.Run()\n");
});

app.Run();

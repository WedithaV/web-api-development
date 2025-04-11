var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

//Minimap web apis

app.MapGet("/shirts", () =>
{
    return "Reading all the shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Reading shirt id : {id}";
});

app.MapPost("/shirts", () =>
{
    return "Create shirt";
});

app.MapPut("/shirts/{id}", (int id) =>
{
    return $"Update shirtd id : {id}";
});

app.MapDelete("/shirts/{id}", (int id) => {
    return $"Delete shirt id : {id}";
});

app.Run();

using DataAccessesLayerApi;

var builder = WebApplication.CreateBuilder(args);

// ≈⁄œ«œ «·« ’«· »ﬁ«⁄œ… «·»Ì«‰« 
clsAccesseSetting.Initialize(builder.Configuration);

// ≈÷«›… «·Œœ„« 
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//  ›⁄Ì· Swagger œ«∆„« (Õ Ï ⁄·Ï «·”Ì—›—)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();

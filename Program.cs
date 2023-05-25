using Platform;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();
var app = builder.Build();


app.Map("/index",async(context)=> {
    await WeatherEndpointHttpContext.Endpoint(context);
    });
app.MapWeather("endpoint/adapterclass");
app.MapEndpoint<WeatherEndpoint>("endpoint/utilityclass");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

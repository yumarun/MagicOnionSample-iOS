using MagicOnion;
using MagicOnion.Server;


var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseKestrel(option =>
{
    option.ConfigureEndpointDefaults(endpointOptions =>
    {
        endpointOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
    });
});


builder.Services.AddGrpc();
builder.Services.AddMagicOnion();


var app = builder.Build();

app.MapMagicOnionService();

app.Run();

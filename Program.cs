using System.Net.Security;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel with specific SSL options
if (OperatingSystem.IsLinux())
{
    builder.WebHost.ConfigureKestrel(serverOptions =>
    {
        serverOptions.ConfigureHttpsDefaults(httpsOptions =>
        {
            httpsOptions.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
            httpsOptions.OnAuthenticate = (context, sslOptions) =>
            {
                sslOptions.CipherSuitesPolicy = new CipherSuitesPolicy(
                    new[] { TlsCipherSuite.TLS_RSA_WITH_AES_256_CBC_SHA256 });
            };
        });
    });
}

var app = builder.Build();

app.MapGet("/student", () => "Artem Yurchenko [KP-22]");

app.Run();
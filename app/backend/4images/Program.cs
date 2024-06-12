using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using _4images.Data;
using _4images.Services;
using _4images;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "http://localhost:5173";

// vari�veis de ambiente do .env
Env.Load();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:5173");
                      });
});

// JWT
var secretKey = Environment.GetEnvironmentVariable("SECRET_KEY");
if (string.IsNullOrEmpty(secretKey))
{
    throw new InvalidOperationException("A chave secreta do JWT n�o foi encontrada nas vari�veis de ambiente.");
}
builder.Services.AddSingleton(new TokenService(secretKey));

// contexto do banco de dados
var connectionString = Environment.GetEnvironmentVariable("DEFAULT_CONNECTION");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("A string de conex�o do banco de dados n�o foi encontrada nas vari�veis de ambiente.");
}
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// BlobService
builder.Services.AddSingleton<BlobService>();
// UserService
builder.Services.AddScoped<UserService>();
// TransactionService
builder.Services.AddScoped<TransactionService>();
// LikeService
builder.Services.AddScoped<LikeService>();

// google auth
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
    };
})
.AddGoogle(options =>
{
    var googleClientId = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_ID");
    var googleClientSecret = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_SECRET");

    if (string.IsNullOrEmpty(googleClientId) || string.IsNullOrEmpty(googleClientSecret))
    {
        throw new InvalidOperationException("As credenciais do Google Auth n�o foram encontradas nas vari�veis de ambiente.");
    }

    options.ClientId = googleClientId;
    options.ClientSecret = googleClientSecret;
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.OperationFilter<FileOperationFilter>();
});

var app = builder.Build();

// pipeline de requisi��es HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
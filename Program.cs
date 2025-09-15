using GitClash.Infrastructure;
using GitClash.Infrastructure.Auth;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<GitClashDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services (JWT, GitHub client, etc.)
builder.Services.AddScoped<JwtService>();
builder.Services.AddScoped<GithubOAuthService>();

var app = builder.Build();

app.UseHttpsRedirection();

// Map endpoints


app.Run();
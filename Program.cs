using Cocona;
using Microsoft.Extensions.DependencyInjection;

var builder = CoconaApp.CreateBuilder();

builder.Services.AddSingleton<EmailService>();
builder.Services.AddSingleton<ReportService>();
builder.Services.AddSingleton<CleanupService>();

var app = builder.Build();

app.AddCommands<AppCommands>();

app.Run();

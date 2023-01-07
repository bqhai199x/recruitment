using Recruitment.Infrastructure;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Debug()
			.WriteTo.File(path: "logs/Debug/Log_.txt",
					restrictedToMinimumLevel: LogEventLevel.Debug,
					rollingInterval: RollingInterval.Day,
					rollOnFileSizeLimit: true,
					fileSizeLimitBytes: 2097152)
			.WriteTo.File(path: "logs/Info/Log_.txt",
					restrictedToMinimumLevel: LogEventLevel.Information,
					rollingInterval: RollingInterval.Day,
					rollOnFileSizeLimit: true,
					fileSizeLimitBytes: 2097152)
			.WriteTo.File(path: "logs/Error/Log_.txt",
					restrictedToMinimumLevel: LogEventLevel.Error,
					rollingInterval: RollingInterval.Day,
					rollOnFileSizeLimit: true,
					fileSizeLimitBytes: 2097152)
			.CreateLogger();

app.Run();

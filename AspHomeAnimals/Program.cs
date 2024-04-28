using AspHomeAnimals.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configure Razor Pages options.
builder.Services.Configure<RazorPagesOptions>(options =>
{
    options.RootDirectory = "/Pages";
});

// Add animal service.
builder.Services.AddScoped<IAnimalService, AnimalService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();

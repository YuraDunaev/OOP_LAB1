using OOP_LAB1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<FigureList>();

var app = builder.Build();

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapRazorPages();


app.MapGet("/hello", () => {
    return new List<string>() {
        "Hello World!",
        "Hello Galaxy!",
        "Hello Universe!"
    };
});

app.MapDefaultControllerRoute();

app.Run();

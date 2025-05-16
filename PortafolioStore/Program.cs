using Methods.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ✅ Usa controladores con vistas
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<CategoryRepository>();
builder.Services.AddScoped<ProductRepository>();

var app = builder.Build();




// Configura el pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ Usa rutas de controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Store}/{action=Index}/{id?}"
);



app.Run();

using Microsoft.EntityFrameworkCore;
using Examen_T1_Prueba.Datos; // Asegúrate de que este namespace coincida con tu proyecto

var builder = WebApplication.CreateBuilder(args);

// 1. Configuración de la Base de Datos (Entity Framework)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Add services to the container (Controladores y Vistas)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3. Configure the HTTP request pipeline (Pipeline de ejecución)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 4. Configuración de Rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
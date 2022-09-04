using MyProject.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Startup ayarlamalar�n� buradan yap�yoruz yani sevisleri burada ekliyoruz
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Otanticationlar burada tan�mlan�yor
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

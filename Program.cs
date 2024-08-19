var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //kapsayıcı servis ekleme AddControllers view çalışmaz. onun yyerine AddcontrollersWithViews

var app = builder.Build(); //uygulama build edildi

app.UseStaticFiles(); //wwwroot aktif etme

app.UseRouting(); //yönlendirme

// {controller=home}/{action=index}/id?
//app.MapDefaultControllerRoute(); //şema aktif oluyor

app.MapControllerRoute
(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run(); //uygulama çalıştır

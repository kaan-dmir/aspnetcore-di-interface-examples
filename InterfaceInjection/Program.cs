using InterfaceInjection.Abstract;
using InterfaceInjection.Business;
using InterfaceInjection.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPaymentProvider, StripePaymentProvider>();
builder.Services.AddScoped<PaymentManager>();
// DI Container
// IPaymentProvider ihtiyacını StripePaymentProvider implementasyonu ile karşılar
// PaymentManager nesnesini oluşturur.

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

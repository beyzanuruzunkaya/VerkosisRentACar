using VerkosisRentACar.Context;
using VerkosisRentACar.Mapping;
using VerkosisRentACar.VeriErisim.Abstract;
using VerkosisRentACar.VeriErisim.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RentACarDbContext>();
builder.Services.AddScoped<IAracRepository,AracRepository>();
builder.Services.AddScoped<IUyeRepository,UyeRepository>();
builder.Services.AddScoped<IKiralananAracRepository, KiralananAracrepository>();

builder.Services.AddAutoMapper(typeof(RentMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Auth}/{action=Login}/{id?}");

app.Run();

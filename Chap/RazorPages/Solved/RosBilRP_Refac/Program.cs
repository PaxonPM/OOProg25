using RosBilRP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IBilRepository, BilRepository>();
builder.Services.AddSingleton<IKundeRepository, KundeRepository>();
builder.Services.AddSingleton<ILejeRepository, LejeRepository>();
builder.Services.AddSingleton<IAnsatRepository, AnsatRepository>();
builder.Services.AddSingleton<IOpgaveRepository, OpgaveRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

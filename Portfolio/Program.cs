var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseStaticFiles();
app.MapRazorPages();
//.net 9 specific things. Downgraded to .net 8 because of ubuntu 24.04
//app.MapStaticAssets();
//app.MapRazorPages()
//    .WithStaticAssets();

app.Run();
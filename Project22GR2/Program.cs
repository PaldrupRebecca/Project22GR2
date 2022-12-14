using Project22GR2.Interfaces;
using Project22GR2.Services;

var builder = WebApplication.CreateBuilder(args);
//Login til bruger er something og username er test@test.test
//Alt login: email: qwe@rty.dk, password: 1234
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IEventRepository, JsonEventRepository>();
builder.Services.AddTransient<IMemberRepository, JsonMemberRepository>();
builder.Services.AddTransient<IBoatRepository, JsonBoatRepository>();
builder.Services.AddTransient<IEmployeeRepository, JsonEmployeeRepository>();
builder.Services.AddTransient<IJoinEventRepository, JsonJoinEventRepository>();
builder.Services.AddTransient<IBlogPostRepository, JsonBlogPostRepository>();
builder.Services.AddSingleton<LoginService>();
builder.Services.AddTransient<IBookingRepository, JsonBookingRepository>();
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

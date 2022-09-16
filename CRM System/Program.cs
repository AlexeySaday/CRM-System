using CRM_System.Data;
using Microsoft.EntityFrameworkCore;
using CRM_System.IDataModel;
using CRM_System.DataBase;

var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAppData,PostrgreDb>();
builder.Services.AddDbContext<PostDatabase>(
        op=>op.UseNpgsql(builder.Configuration.GetConnectionString("CrmDataBase"))
    );
var app = builder.Build(); 
 
app.UseStaticFiles();
app.UseDefaultFiles();
app.UseRouting();
app.MapControllerRoute(
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{id?}"
    ); 
app.Run();

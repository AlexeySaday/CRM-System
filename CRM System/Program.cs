using CRM_System.Data;
using CRM_System.IDataModel;

var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAppData,DataList>();
var app = builder.Build(); 
 
app.UseStaticFiles();
app.UseDefaultFiles();
app.UseRouting();
app.MapControllerRoute(
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{id?}"
    );;

//List<Message> messages = new List<Message>()
//{
//    new("����� ����������","�������� ������"),
//    new("����� ��������","������������ �������")
//};
//app.MapGet("/api/messages", () => messages);
//app.MapGet("/api/messages/{id}",(string id) =>
//{
//    Message? message = messages.Where(x => x.Id == id).FirstOrDefault();
//    if (message != null) return Results.NotFound("�� ���������� ����� ������ ���������");
//    return Results.Json(message);
//});
//app.MapPost("/api/messages", (string name, string message) =>
//{
//    messages.Add(new(name, message));
//    return Results.Ok();
//});
 
//app.MapPut("/api/messages", (Message message) =>
//{
//    var m = messages.Where(e => e.Id == message.Id).FirstOrDefault();
//    if (m == null) return Results.NotFound("�� ��������");
//    m.Name = message.Name;
//    m.MessageText = message.MessageText;
//    return Results.Ok();
//});
app.Run();

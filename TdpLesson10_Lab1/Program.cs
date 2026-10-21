namespace TdpLesson10_Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            // Route cho danh sách sinh viên
            app.MapControllerRoute(
                name: "studentList",
                pattern: "Admin/Student/List",
                defaults: new
                {
                    controller = "Student",
                    action = "Index"
                })
                .WithStaticAssets();

            // Route cho form thêm sinh viên
            app.MapControllerRoute(
                name: "studentAdd",
                pattern: "Admin/Student/Add",
                defaults: new
                {
                    controller = "Student",
                    action = "Create"
                })
                .WithStaticAssets();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Student}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}

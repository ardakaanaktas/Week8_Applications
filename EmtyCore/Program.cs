namespace EmtyCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //MVC modelinin uygulanmasý için Model - View - Controller kavramlarýnýn uygulanmasý gerekmektedir.

            //Model kýsmý için bir sýnýf oluþturuldu.

            //View kýsmý için bir Razor sayfasý oluþturuldu.

            //Controller kýsmý için bir Controller sýnýfý oluþturuldu.

            //Controller sýnýfý, View kýsmý ile Model kýsmýný birleþtirerek kullanýcýya sunar.

            //Yukarýda oluþturduðumuz builder nesnesi ile MVC modelini uygulamak için gerekli olan servisler eklenir.
            builder.Services.AddControllersWithViews();

            //Ardýndan builder nesnesi ile uygulama oluþturulur.
            var app = builder.Build();

            //HTTP isteklerinin iþlenmesi için gerekli olan pipeline oluþturulur.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //Static dosyalarýn kullanýlabilmesi için gerekli middleware eklenir.
            app.UseStaticFiles();

            //Routing iþlemleri için gerekli middleware eklenir.
            app.UseRouting();

            //Yetkilendirme iþlemleri için gerekli middleware eklenir.
            app.UseAuthorization();

            //Controller sýnýflarýnýn yönlendirilmesi için gerekli middleware eklenir.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //Uygulamanýn çalýþtýrýlmasý için Run metodu çaðrýlýr.
            app.Run();
        }
    }
}

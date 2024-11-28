namespace EmtyCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //MVC modelinin uygulanmas� i�in Model - View - Controller kavramlar�n�n uygulanmas� gerekmektedir.

            //Model k�sm� i�in bir s�n�f olu�turuldu.

            //View k�sm� i�in bir Razor sayfas� olu�turuldu.

            //Controller k�sm� i�in bir Controller s�n�f� olu�turuldu.

            //Controller s�n�f�, View k�sm� ile Model k�sm�n� birle�tirerek kullan�c�ya sunar.

            //Yukar�da olu�turdu�umuz builder nesnesi ile MVC modelini uygulamak i�in gerekli olan servisler eklenir.
            builder.Services.AddControllersWithViews();

            //Ard�ndan builder nesnesi ile uygulama olu�turulur.
            var app = builder.Build();

            //HTTP isteklerinin i�lenmesi i�in gerekli olan pipeline olu�turulur.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //Static dosyalar�n kullan�labilmesi i�in gerekli middleware eklenir.
            app.UseStaticFiles();

            //Routing i�lemleri i�in gerekli middleware eklenir.
            app.UseRouting();

            //Yetkilendirme i�lemleri i�in gerekli middleware eklenir.
            app.UseAuthorization();

            //Controller s�n�flar�n�n y�nlendirilmesi i�in gerekli middleware eklenir.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //Uygulaman�n �al��t�r�lmas� i�in Run metodu �a�r�l�r.
            app.Run();
        }
    }
}

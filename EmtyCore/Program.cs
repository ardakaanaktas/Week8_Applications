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

            /*
             
            Controller:
            Kullan�c� isteklerini al�r ve i�ler.
            Model nesnelerini olu�turur veya g�nceller.
            View'a hangi verilerin g�nderilece�ine karar verir.
            Uygun View'a y�nlendirme yapar.

            Action:
            Controller i�indeki bir metottur.
            Bir kullan�c� iste�ine kar��l�k gelen i�lemleri ger�ekle�tirir.
            Genellikle HTTP metodlar�na (GET, POST, PUT, DELETE) kar��l�k gelir.

            Model:
            Uygulama verilerini temsil eder.
            Veritaban� tablolar�na veya di�er veri kaynaklar�na kar��l�k gelebilir.
            View'a ba�lanarak kullan�c� aray�z�nde g�r�nt�lenir.

            View:
            Kullan�c� aray�z�n� olu�turur.
            Model'deki verileri kullanarak dinamik i�erik �retir.
            Razor syntax ile yaz�l�r.

            Razor:
            View'lar� olu�turmak i�in kullan�lan bir templating dilidir.
            C# kodunu HTML ile kar��t�rmaya olanak sa�lar.
            RazorView:
            Razor syntax ile yaz�lm�� bir View dosyas�d�r.

            wwwroot:
            Statik dosyalar�n (CSS, JavaScript, resimler) sakland��� klas�rd�r.
            Bu dosyalar do�rudan taray�c�ya servis edilir.

            builder.Build() ve app.Run() Metotlar�

            builder.Build():
            Uygulama yap�land�rmas�n� tamamlayarak bir IHostBuilder nesnesi olu�turur.
            Bu nesne, uygulamaya hizmetler eklemek, ortamlar� yap�land�rmak gibi i�lemler i�in kullan�l�r.

            app.Run():
            Olu�turulan IHostBuilder nesnesini kullanarak web sunucusunu ba�lat�r ve istekleri i�lemeye ba�lar.
            Uygulama ya�am d�ng�s�n�n ba�lang�c�d�r.
             
             
             */
        }
    }
}

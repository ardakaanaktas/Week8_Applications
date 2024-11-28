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

            /*
             
            Controller:
            Kullanýcý isteklerini alýr ve iþler.
            Model nesnelerini oluþturur veya günceller.
            View'a hangi verilerin gönderileceðine karar verir.
            Uygun View'a yönlendirme yapar.

            Action:
            Controller içindeki bir metottur.
            Bir kullanýcý isteðine karþýlýk gelen iþlemleri gerçekleþtirir.
            Genellikle HTTP metodlarýna (GET, POST, PUT, DELETE) karþýlýk gelir.

            Model:
            Uygulama verilerini temsil eder.
            Veritabaný tablolarýna veya diðer veri kaynaklarýna karþýlýk gelebilir.
            View'a baðlanarak kullanýcý arayüzünde görüntülenir.

            View:
            Kullanýcý arayüzünü oluþturur.
            Model'deki verileri kullanarak dinamik içerik üretir.
            Razor syntax ile yazýlýr.

            Razor:
            View'larý oluþturmak için kullanýlan bir templating dilidir.
            C# kodunu HTML ile karýþtýrmaya olanak saðlar.
            RazorView:
            Razor syntax ile yazýlmýþ bir View dosyasýdýr.

            wwwroot:
            Statik dosyalarýn (CSS, JavaScript, resimler) saklandýðý klasördür.
            Bu dosyalar doðrudan tarayýcýya servis edilir.

            builder.Build() ve app.Run() Metotlarý

            builder.Build():
            Uygulama yapýlandýrmasýný tamamlayarak bir IHostBuilder nesnesi oluþturur.
            Bu nesne, uygulamaya hizmetler eklemek, ortamlarý yapýlandýrmak gibi iþlemler için kullanýlýr.

            app.Run():
            Oluþturulan IHostBuilder nesnesini kullanarak web sunucusunu baþlatýr ve istekleri iþlemeye baþlar.
            Uygulama yaþam döngüsünün baþlangýcýdýr.
             
             
             */
        }
    }
}

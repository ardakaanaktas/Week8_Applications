namespace LiveLesson1.Models
{
    public static class Veri
    {
        public static List<Hobi> Hobilerim()
        {
            return new List<Hobi>()
            {
                new Hobi() { Ad = "Yüzme", Aciklama = "Denizde yüzmek", Degree = 5 },
                new Hobi() { Ad = "Bisiklet", Aciklama = "Dağ bisikleti", Degree = 3 },
                new Hobi() { Ad = "Koşu", Aciklama = "Maraton koşusu", Degree = 4 },
                new Hobi() { Ad = "Balıkçılık", Aciklama = "Tatlı su balıkçılığı", Degree = 2 },
                new Hobi() { Ad = "Fotoğraf", Aciklama = "Doğa fotoğrafçılığı", Degree = 4 }
            };
    
        } 
    }
}

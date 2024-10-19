using System.Runtime;

public class Personel
{

    public int id;
    // Yeni nesil prop yazarken, artık değişkenleri yazmaya gerek yok 

    // Otomatik Property'ler : Bu property çeşitleri genelde hiç bir private field'i kapsüllemezler
    // kapsülleme ihtiyacınız olduğunda bir önceki yöntem ile kapsülleme işlemi yapılabilir

    // 
    // Property
    public int Id
    {
        get { return id; }
        set
        { id = value; }
    }
    public string Ad { get; set; }

    // yeni yöntemde, kapsüllemede sınıfa ait değişkenler yoktur.(Field) Direk olarak Property'ler yazılır
    // eğer, bir şekilde field yazıp kapsüllemek istersek, get ve set bloklarının içerisinde bu işlemi yapabiliriz

    // Read only erişimler için, get yada sen bloklarından birini yazmayabiliriz, yada bu blokların önüne private keyword'ünü getirebiliriz

    // yaş alanının set özelliği private olduğu için erişilip değiştirilmemektedir.
    public int Yas { get; private set; }

    // istenilirse, bloklardan herhangi birini yazmayabilirsiniz!!!
    public double Maas { get; }

    // istenilirse, pğroperty'lere başlangıç değeri verilebilir
    public string IsYeri { get; set; } = "Karabük demir çelik tesisleri";

    public Personel(int id, string ad, int yas, string isyeri)
    {
        // ortamlarda, eğer otomatik prop varsa ctor içerisinden gelen değerler
        // direk olarak otomatik proplara maplenirler, zaten otomatik prop kullanıyorsa, 
        //field kullanmıyoruzdur!!

        this.Id = id;
        this.Ad = ad;
        this.Yas = yas;
        this.IsYeri = isyeri;
    }

}

// Ctor ile prop kullanımı nasıl olacak !!! 


// Bu konuyu, property ve otomatik property kavramlarını salı günü tekrar konuşacağız.!!!


// Yeni kavramlar nelerdir : 

// Bir class'ın üyesi olan değişkene Field denir
// bir metodun üyesi değişkene local değişken denir
// bir sınıfın encapsulation üyesine property denir!!

// not : iki türlü değişken vardır, birisi metotların ilerisinde yaşayan ve ölen değişkenlerdir.
// bu değişkenlere local değişken denir
// diğer bir değişken türüde, sınıf üyesi değişkenlerdir. Bu değişkenler sınıf yaşadığı sürece yaşarlar
// metotlardan bu değişkenlere erişilebilir
// mantık olarak ,üye seviyesi olarak meetotlarla aynı seviyedelerdir
// sınıf üyesi değişkenlerede field denir 



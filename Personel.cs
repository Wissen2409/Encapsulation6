using System.Runtime;

public class Personel
{


    // Yeni nesil prop yazarken, artık değişkenleri yazmaya gerek yok 

    // Property
    public int Id { get; set; }
    public string Ad { get; set; }

    // yeni yöntemde, kapsüllemede sınıfa ait değişkenler yoktur.(Field) Direk olarak Property'ler yazılır
    // eğer, bir şekilde field yazıp kapsüllemek istersek, get ve set bloklarının içerisinde bu işlemi yapabiliriz

    // Read only erişimler için, get yada sen bloklarından birini yazmayabiliriz, yada bu blokların önüne private keyword'ünü getirebiliriz

    // yaş alanının set özelliği private olduğu için erişilip değiştirilmemektedir.
    public int Yas { get; private set; }

    // istenilirse, bloklardan herhangi birini yazmayabilirsiniz!!!
    public double Maas { get;}

    // 
}

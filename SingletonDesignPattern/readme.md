<H1> Singleton Design Pattern</H1>

Buradaki örneğimizde tek bir kullanıcının bitcoin cüzdanı ele alınmıştır. 

Statik tek instancetır. Uygulama çalıştırıldığında ve sınıf ilk kez kullanıldığında belleğe yüklenir. Bu runtime da gerçekleşir.

Static sınıfların veya üyelerin elle yenir bir örneği oluşturulamaz, direkt sınıf adı ile erişilir.

Static üyeler sınıfa ait olup, sınıfın kendisi ile ilişkilidir, ve herhangi bir değişiklik yapıldığında, bu değişiklik sınıfın kendisi üzerinden yapılır.

Static yapıcı metotlar (static constructors), normal yapıcı metotlardan (instance constructors) önce değil, sınıf ilk kez belleğe yüklenirken çalışır ve yalnızca 
bir kez çalışır.

Static sınıfların ya da üyelerin bellek kullanımı, tek bir örnek üzerinden yönetilir, bu da birden fazla örnek oluşturulması durumunda ortaya çıkabilecek bellek
kullanımından daha verimlidir. Ancak, static üyelerin gereksiz yere kullanımı bellek kullanımını olumsuz etkileyebilir, çünkü program boyunca yaşarlar
ve uygulama kapatılana kadar bellekten temizlenmezler.
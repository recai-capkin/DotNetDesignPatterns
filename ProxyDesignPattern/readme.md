<H1> Proxy Design Pattern </H1>
Proxy tasarım deseni, bir nesnenin başka bir nesneye olan erişimini kontrol etmek için kullanılan yapısal bir desendir. Bu desen, özellikle ağ üzerinden maliyetli işlemleri gerçekleştirirken ya da güvenlik gerektiren durumlarda faydalıdır. Proxy, gerçek nesnenin yerini alarak, ona yapılan çağrıları kontrol eder ve yönlendirir.

Proxy deseninin temel kullanım amaçları şunlardır:

-Erişim Kontrolü: Yetkisiz erişimleri engellemek veya erişimi sınırlamak için kullanılır.
-Lazy Initialization (Tembel Başlatma): Bir nesnenin yaratılmasının ve onun üzerindeki işlemlerin maliyetli olduğu durumlarda, bu nesneye ihtiyaç duyulana kadar bekletmek için kullanılır.
-Logging ve Monitoring: Nesnelere yapılan çağrıların kaydedilmesi ve izlenmesi için kullanılır.
-Remote Object (Uzak Nesne): Ağ üzerinden bir nesneye erişim sağlarken, ağ iletişim detaylarını gizlemek için kullanılır.

Biz bu örnekte ise borsada alım yapacak kullanıcının minium alım limitini 10 $ olarak sınırlandırdık ve kontrollerini gerçekleştirdik.
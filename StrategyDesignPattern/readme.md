![#FF0000](https://placehold.it/15/FF0000/000000?text=+
<H1>Strategy Design Pattern</H1>
<span style="color:green;font-weight:700;font-size:20px;">
    Strategy Design Pattern
</span>
Bu tasarım deseninde çalışma zamanında borsa üzerindeki kullanıcıların fee hesaplama stratejisini değiştirmeyi amaçladık.
Burada kullandığımız 2 farklı fee türü var bunlar maker ve taker olarak ayrılmıştır.
ISetUserFee isimli bir strategy interface tanımlanmıştır. Bu interface SetUserMakerFee ve SetUserTakerFee olarak iki metot imzasına sahiptir.
ExchangeUser isimli context class ımızı oluşturduk. Bu class içerisindeki yapıcı metodumuza parametre olarak ISetUserFee interfac imizi verdik.)
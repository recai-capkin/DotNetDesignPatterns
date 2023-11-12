
<H1 style="color:purple;">Strategy Design Pattern</H1>
<span style="color:![#FF0000];font-weight:700;font-size:20px;">
    Strategy Design Pattern
</span>
Bu tasarım deseninde çalışma zamanında borsa üzerindeki kullanıcıların fee hesaplama stratejisini değiştirmeyi amaçladık.
Burada kullandığımız 2 farklı fee türü var bunlar maker ve taker olarak ayrılmıştır.
ISetUserFee isimli bir strategy interface tanımlanmıştır. Bu interface SetUserMakerFee ve SetUserTakerFee olarak iki metot imzasına sahiptir.
ExchangeUser isimli context class ımızı oluşturduk. Bu class içerisindeki yapıcı metodumuza parametre olarak ISetUserFee interface imizi verdik.
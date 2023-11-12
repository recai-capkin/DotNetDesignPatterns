
<H1>Strategy Design Pattern</H1>
Bu tasarım deseninde çalışma zamanında borsa üzerindeki kullanıcıların fee hesaplama stratejisini değiştirmeyi amaçladık.
Burada kullandığımız 2 farklı fee türü var bunlar maker ve taker olarak ayrılmıştır.
ISetUserFee isimli bir strategy interface tanımlanmıştır. Bu interface SetUserMakerFee ve SetUserTakerFee olarak iki metot imzasına sahiptir.
ExchangeUser isimli context class ımızı oluşturduk. Bu class içerisindeki yapıcı metodumuza parametre olarak private ISetUserFee interface imizi verdik.
Böylelikle bu field değerini doğrudan değiştirebilmek için dışarıdan erişim mümkün değildir.
Sonrasında eklediğimiz OtcUser, UnVerified, VerifiedUser ve VipUser classlarımıza ISerUserFee yi implement ediyoruz.
Böylelikle ExchangeUser classımız ISerUserFee arayüzüne dayalı herhangi bir stratejiyi kabul edecektir.

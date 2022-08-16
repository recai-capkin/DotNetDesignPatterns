# Factory Design Pattern

Buradaki örnekte bir erc-20 token üretilmesi için gerekli bir yapıyı factory design pattern ile kuracağız.
Erc-20 etherium ağında token üretmek için belirli kuralları ve standartları tanımlayan bir protokol standartıdır.


**IErc20** tipinde bir arayüz oluşturuldu. Ve bunun içerisinde erc20 protokollerinin kuralları yazıldı. Ve sonrasında ise 
Erc 20 ile oluşturulmuş coinler belirlendi.(***Dent Holo Tether***) Bunlar tamamlanınca verilen bilgilere göre nesneleri oluşturacak 
factory metotdu ve sınıfı tanımlandı **Erc20Factory**
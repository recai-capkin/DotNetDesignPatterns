# Decorator Design Pattern


Decorator tasarım deseni, bir nesnenin davranışını veya işlevselliğini, alt sınıflara dal ayrımı yapmadan dinamik olarak genişletmek için kullanılır. Bu desen, mevcut nesnelerin üzerine ekstra özellikler eklemek veya mevcut özelliklerini değiştirmek için kullanılırken, nesnenin sınıfının değiştirilmesine gerek kalmaz. Aynı zamanda kod tekrarı ve kod çokluğu da
engellenir.
Burada örnek olarak abstract bir ***CryptoCurrency*** classı oluşturuldu. Bu bizim için componenttir. Ve ***Cryptocurrency*** altında madencilik yapılabilir
coinler bulunmaktadır bunu ***MineableCurrency*** ile tanımladık. ***MineableCurrency*** bir currency çeşidimizdir. Buna yeni özellikler 
ekliyoruz
# Decorator Design Pattern

Decorator tasarım deseni çalışma zamanında işlevselliği genişletmek ve değiştirmek için kullanılır. Aynı zamanda kod tekrarı ve kod çokluğu da
engellenir.
Burada örnek olarak abstract bir ***CryptoCurrency*** classı oluşturuldu. Bu bizim için componenttir. Ve ***Cryptocurrency*** altında madencilik yapılabilir
coinler bulunmaktadır bunu ***MineableCurrency*** ile tanımladık. ***MineableCurrency*** bir currency çeşidimizdir. Buna yeni özellikler 
ekliyoruz
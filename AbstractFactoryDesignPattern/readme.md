<H1> ABSTRACT FACTORY DESIGN PATTERN </H1>

Creational design patternlardan biridir. Abstract classlar veya interfaceler kullanılarak farklı yöntemler ile gerçekleştirilebilir

Buradaki örneğimizde bir kripto para borsasının farklı ülkelerde farklı işleri ele alındı. 
Örneğin Binance borsası ingiltere veya türkiye için farklı koşulları olabilir. Türkiyede yapılan spot işlemlerin 
farklı tahtalarda işlendiği veya komisyon farklılıkları olabilir. Veya Sadece bir ülkede kullanıcılara özel spot işlem promosyonları
yapılabilir. Bu sebepten ötürü birden fazla ürün oluşabilir ve bu ürün ailelerinin oluşumlarını istemci tarafından ayırabilmeliyiz.
Böylelikle karar verme koşulu olmadan, esnek ve geliştirilebilir bir yapı kurabiliriz.
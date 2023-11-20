# Facade Design Pattern

Facade (***Cephe***) tasarım deseni, karmaşık bir sistemin, alt sistemlerin işlevselliğini birleştiren ve daha yüksek seviye bir arayüz sağlayan bir sınıf veya sınıflar aracılığıyla basitleştirilmesini sağlar. Bu desen, istemci sınıfların alt sistemlerin karmaşık yapısını anlamadan kolayca kullanabilmesi için bir cephe sağlar.

Facade Pattern'in Faydaları:

**Basitlik**: İstemci, bir dizi karmaşık alt sistemle doğrudan etkileşim kurmak yerine, tek bir basitleştirilmiş arayüzle çalışır.<br>
**Soyutlama**: Alt sistemlerin uygulanması ve karmaşıklığı istemciden soyutlanır.<br>
**Sürdürülebilirlik**: Alt sistemlerde yapılan değişiklikler, istemci kodu üzerinde minimum etki yaratır, bu da sürdürülebilirliği ve bakımı kolaylaştırır.<br>

Bu örnekte, **WalletManager**, **TradingEngine** ve **VerificationService** sınıfları kripto para borsasının çeşitli alt sistemlerini temsil eder. **CryptoExchangeFacade** sınıfı, kullanıcıların bu alt sistemlerle kolayca etkileşim kurabilmesi için bir cephe görevi görür. İstemci, yalnızca **MakeTrade** metodunu çağırarak tüm alım satım işlemlerini gerçekleştirebilir. Bu, kullanıcıdan alt sistemlerin karmaşıklığını gizler ve işlemi basitleştirir.

'RRGGBB'
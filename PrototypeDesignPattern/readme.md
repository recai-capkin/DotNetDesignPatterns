<H1>Prototype Design Pattern</H1>

**ICryptoCurrencyPrototype** interface i Clone isimli metot imzasını taşır. **CryptoCurrency** ve **ExchangeAccount** sınıflarına implemente edilir.
**CryptoCurrency** sınıfı, yalnızca yüzeysel bir kopya yaratırken, **ExchangeAccount** sınıfı, portföy listesini de içerdiği için derin bir kopya yaratır. 
Böylece, hesap klonlandığında portföy listesindeki her bir **CryptoCurrency** nesnesi de ayrı ayrı klonlanmış olur.


**Program** sınıfında, önce bir **CryptoCurrency** prototipi oluşturulur ve bir **ExchangeAccount** içine eklenir. Daha sonra bu hesap klonlanır ve klon üzerinde değişiklikler yapılır. Her iki hesabın bilgileri konsola yazdırıldığında, orijinal hesabın değişmediği ve klonlanmış hesabın farklı bir ID ve güncellenmiş fiyat içerdiği görülür.
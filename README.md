# OtelOtomasyonu

Bu projede ADO.NET ile Katmanlı Mimari esas alınarak(Entity/Facade) Generic Mimari ile veritabanındaki her tablo için tek bir Select , Insert , Update , Delete sorguları uygulanmıştır.Solution da yer alan 'OtelOtomasyonu_ORM.Entity' klasöründeki class'lar veritabanımızdaki tablolara karşılık gelmektedir.(Tablo isimleri ile class isimlerinin ve class'ların property'lerinin de kolon isimleri ile aynı olmasına dikkat edilmiştir.) Veri tabanımızdaki Store Procedure 'lerin isimleri de belli bir standarda uygun olarak verilmiştir.(prc_(tabloAdi)_(SorguAdi))

# Login 

Uygulamanın çalışma anında satış gerçekleştiren personeli arka tarafta tutmak için yapılan giriş paneli sayfası.

![1](https://user-images.githubusercontent.com/94843366/158719108-40b1fb8c-dac7-4ebf-aea0-5f31ac393fc0.png)

# Sql Database Konfigürasyonları

Projemizde tüm sınıflarımıza(entitiy'lere) karşılık gelen veritabanındaki tablolar entegre bir şekilde çalışmaktadır.

![2](https://user-images.githubusercontent.com/94843366/158719128-d76cb805-89ff-405c-864d-c74a8cd3c970.png)


![4](https://user-images.githubusercontent.com/94843366/159604223-86604d8c-ce2b-49ff-b875-257ff1dc1fa3.png)

# Store Procedure

Projede kullanılan store procedure' lerin tek tip olmasına dikkat edilmiştir.(Sorgularda tek değişen kısım sorgu adı olması için => Select ,Insert , Update , Delete)
![5](https://user-images.githubusercontent.com/94843366/159605352-40b0d4d3-f499-4312-bba1-017f9a55c326.png)


![4](https://user-images.githubusercontent.com/94843366/158720271-7399dfe0-56c2-40ff-98c4-a99e188fd512.png)



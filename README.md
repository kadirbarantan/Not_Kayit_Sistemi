# Not Kayıt Sistemi

Bu proje, **C# Windows Forms Application** kullanılarak geliştirilmiş bir **Not Kayıt Sistemi** uygulamasıdır.  
Öğrenci ve öğretmen girişlerine göre farklı yetkiler sunar ve SQL Server veritabanı ile çalışır.

Bu proje eğitim amaçlı geliştirilmiştir.Ancak eğitim örneğinin üzerine kendim **Sınav notlarının en fazla 100 olması kontrolü**,**Geçen/Kalan öğrenci sayısını gösterme**,**İkinci defa okul numarası girişi yapılırken 1111 kullanılması durumunda yine öğretmen sayfasına yönlendirilmesi**,**Öğrenci sayfasında Geçme/Kalma durumunu True/False yerine Geçti/Kaldı gösterimi** geliştirmelerini yaptım.

## Özellikler

### Öğrenci
- Okul numarası ile sisteme giriş
- Ad–soyad bilgilerini görüntüleme
- Sınav notlarını görüntüleme
- Ortalama ve geçme / kalma durumunu görme

### Öğretmen
-Öğretmen sayfasına girebilmek için okul numaraası yerine **1111** yazılır.
- Öğrenci ekleme
- Öğrenci notlarını güncelleme
- Sınıf listesini görüntüleme
- Ortalama, geçen ve kalan öğrenci sayılarını görme

## Kullanılan Teknolojiler
- C#
- Windows Forms
- SQL Server
- ADO.NET

## Veritabanı Kurulumu
1. SQL Server Management Studio açılır
2. **DbNotKayit** adında bir veritabanı oluşturulur
3. `Database/DbNotKayit.sql` dosyası açılır
4. Script çalıştırılarak tablolar oluşturulur

## Proje Yapısı
- `Not_Kayit_Sistemi` : Windows Forms uygulaması
- `Database` : SQL Server veritabanı scripti

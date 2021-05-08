# :blue_car: Rent A Car | Araba kiralama Projesi

Proje Katmanlı Mimarı yapısıyla, SOLID prensiplerine uygun olarak geliştirilmiş Araba Kiralama projesidir.
 Projede 5 adet katman bulunmaktadır.
<br/>

 [Projenin Frontend Kısmı](https://github.com/merveakbulutt/RecapProject-Frontend)
##   :star:   Katmanlar:
 
### :file_folder:Entities:
Bu katmanda veritabanında yer alacak olan nesneler oluşturulur. Oluşturulacak veritabanı nesneleri bir sınıf halinde oluşturulur ve içerisinde propertyler ile veritabanında yer alacak olan tabloların alanları belirlenir.DTO larımız bu katmanda yer alır
 
### :file_folder: Business:
İş kodlarının yazıldığı katmandır.Data Access’te çektiğimiz verileri Business katmanda işleriz. 
    Böylelikle projemizde bağımlılıkları ortadan kaldırmış, projenin okunabilirliği ve geliştirilebilirliği daha açık hale getirmiş oluruz.

### :file_folder: DataAccess:
Bu katmanda CRUD işlemi olarak adlandığımız ekleme (Create), okuma (Read), güncelleme (Update) ve silme (Delete) 
    gibi  veritabanı işlemleri yapılmaktadır.
    Bu katmanda sadece Veritabanına ait kodlar yazılır.
  

### :file_folder: WebAPI:
Restful HTTP protokolü ile dış dünaya açtığımız katmandır.
   Business katmanında yazdığımız service'leri kullanarak Http Post, Get işlemleri yapılır
 
### :file_folder:   Core:
   Core katmanı ortak kodların bulunduğu katmandır.
   Diğer katmanları referans almaz ve tüm projelerde kullanılabilir.
   Adının Asp.Net Core ile bir ilişkisi yoktur.
##  :star: Kullanılan Teknolojiler ve Frameworkler
- Net Core 3.1  
- AOP
- Autofac
- Fluent Validation(Validasyon)
- jwt(kimlik doğrulaması)
- Entity Framework ORM Tool’u kullanılmıştır. Model oluşturulurken Code First yöntemi tercih edilmiştir. 
- Log4Net(Loglama) 
- Exception Middleware (Hata mekanizması)
- Cache  (Microsoft Memory Cache)

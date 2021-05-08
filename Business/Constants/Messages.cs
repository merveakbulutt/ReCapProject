using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
  public  class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarListed = "Arabalar Listelendi";
       
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalDeleted = "Kiralama işlemi Silindi.";
        public static string RentalInvalid = "Araba teslim edilmediği için şuan kiralanamz.";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar Listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler Listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string CarImageAdded = "Araç resimleri eklendi";
        public static string CarImageDeleted = "Araç resimleri silindi";
        public static string CarImageUpdated = "Araç resimleri güncellendi";


        public static string MaintenanceTime = "Sistem bakımda";
        public static string BrandInvalid = "Marka ismini 2 karakterden fazla giriniz";
        public static string CarDailyPrice = "günlük fiyat 0'dan büyük olmalıdır";
        public static string CarImageLimitExceded = "En fazla 5 resim yüklenebilir.";

        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string CardAdded = "Kart bilgileri eklendi";
        public static string CardDeleted = "Kart bilgileri silindi";
        public static string CardUpdated = "Kart bilgileri güncellendi";

        public static string PaymentAdded = "Ödeme Başarılı";
    }
}

using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants // Constant = Proje sabitleri buraya yazılıyor.
{
    public static class Messages // static verdiğimizde artık new'lemeye gerek kalmıyor.
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError ="Bir kategoride 10'dan fazla ürün olamaz.";
        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string ImageLimitExceded = "Resim limiti aşıldı.";
        public static string ImageAdded = "Resim Eklendi.";
        public static string ImageDeleted = "Resim silindi.";
        public static string ImageUpdate = "Resim güncellendi.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Erişim belirteci oluşuruldu.";
    }
}

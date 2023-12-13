using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        public static string productAdded = "Ürün başarıyla eklendi : ";
        public static string productDeleted = "Ürün başarıyla silindi : ";
        public static string productUpdated = "Ürün başarıyla güncellendi : ";

        public static string categoryAdded = "Kategori başarıyla eklendi : ";
        public static string categoryDeleted = "Kategori başarıyla silindi : ";
        public static string categoryUpdated = "Kategori başarıyla güncellendi : ";

        public static string UserNotFound = "Kullanıcı Bulunamadı : ";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş İşlemi Başarılı";

        public static string UserAlreadyExists = "Bu Kullanıcı Zaten Mevcut";

        public static string UserRegistered = "Kullanıcı Başarıyla Kayıt Edildi ";

        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
    }
}

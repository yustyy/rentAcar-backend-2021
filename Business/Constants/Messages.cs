using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Marka eklendi";

        public static string BrandDeleted = "Marka silindi";

        public static string BrandsListed = "Markalar listelendi";

        public static string BrandListed = "Marka listelendi";

        public static string BrandUpdated = "Marka güncellendi";

        public static string CarAdded = "Araba eklendi";

        public static string CarDescriptionInvalid = "Araba'nın açıklaması geçersiz!";

        public static string CarDailyPriceInvalid = "Araba'nın günlük ücreti geçersiz!";

        public static string CarDeleted = "Araba silindi";

        public static string CarsListed = "Arabalar listelendi";

        public static string CarListed = "Araba listelendi";

        public static string CarUpdated = "Araba güncellendi";

        public static string ColorAdded = "Renk eklendi";

        public static string ColorDeleted = "Renk silindi";

        public static string ColorsListed = "Renkler listelendi";

        public static string ColorListed = "Renk listelendi";

        public static string ColorUpdated = "Renk güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";

        public static string UserDeleted = "Kullanıcı silindi";

        public static string UsersListed = "Kullanıcılar listelendi";

        public static string UserListed = "Kullanıcı listelendi";

        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string CustomerAdded = "Müştei eklendi";

        public static string CustomerDeleted = "Müşteri silindi";

        public static string CustomersListed = "Müşteriler listelendi";

        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string RentalAdded = "Sipariş eklendi";

        public static string RentalDeleted = "Sipariş silindi";

        public static string RentalsListed = "Siparişler listelendi";

        public static string RentalListed = "Sipariş listelendi";

        public static string RentalUpdated = "Sipariş güncellendi";

        public static string RentalCarAlreadyInUse = "Sipariş edilemedi. Sipariş edilen araba kullanımda";

        public static string BrandNameInvalid = "Marka ismi geçersiz!";

        public static string CarBrandIdInvalid = "Araba marka id geçersiz!";

        public static string CarColorIdInvalid = "Araba renk id geçersiz!";

        public static string CarModelYearInvalid = "Araba model yılı geçersiz!";

        public static string ColorNameInvalid = "Renk ismi geçersiz!";

        public static string CustomerUserIdInvalid = "Müşteri kullanıcı id geçersiz!";

        public static string RentalCarIdInvalid = "Kiralanan araba id geçersiz!";

        public static string RentalCustomerIdInvalid = "Kiralanan müşteri id geçersiz!";

        public static string RentalRentDateInvalid = "Kiralanan kira tarihi geçersiz!";

        public static string RentalReturnDateInvalid = "Kiralanan kira dönüş tarihi id geçersiz!";

        public static string UserEmailInvalid = "Kullanıcı email geçersiz!";

        public static string UserFirstNameInvalid = "Kullanıcı ismi geçersiz!";

        public static string UserLastNameInvalid = "Kullanıcı soyismi geçersiz!";

        public static string UserPasswordInvalid = "Kullanıcı şifresi geçersiz!";

        public static string CarImageAdded = "Araba fotoğrafı eklendi!";

        public static string CarImageDeleted = "Araba fotoğrafrı silindi!";

        public static string AuthorizationDenied = "Yetkiniz yok!";

        public static string UserRegistered = "Kayıt oldu!";

        public static string UserNotFound = "Kullanıcı bulunamadı!";

        public static string PasswordError = "Parola hatası!";

        public static string SuccessfulLogin = "Başarılı giriş!";

        public static string UserAlreadyExists = "Kullanıcı mevcut!";

        public static string AccessTokenCreated = "Token oluşturuldu!";

        public static string CarImageCountOfCarError;

        public static string creditCardAdded = "Kredi kartı eklendi!";

        public static string CarImageUpdated = "Araba fotoğrafı güncellendi!";

        public static string creditCardDeleted = "Kredi Kartı silindi!";

        public static string FindeksAdded = "Findeks puanı eklendi!";

        public static string FindeksUpdated = "Findeks puanı güncellendi!";

        public static string FindeksDeleted = "Findeks puanı silindi!";

        public static string RentalUndeliveredCar = "Araba teslim edilmedi!";

        public static string RentalNotAvailable = "Seçtiğiniz araba belirlenen tarihler arasında kullanılabilir değil!";

        public static string FindeksNotFound = "Findeks puanı bulunamadı!";

        public static string FindeksNotEnoughForCar = "Findeks puanı yereli değil!";

        public static string OperationClaimAdded = "Operasyon claimi eklendi!";

        public static string OperationClaimUpdated = "Operasyon claimi güncellendi!";

        public static string OperationClaimDeleted = "Operasyon claimi silindi!";

        public static string UserOperationClaimAdded = "Kullanıcı operasyon claimi eklendi!";

        public static string UserOperationClaimUpdated = "Kullanıcı operasyon claimi güncellendi!";

        public static string UserOperationClaimDeleted = "Kullanıcı operasyon claimi silindi!";

        public static string UserDetailsUpdated = "Kullanıcı detayı güncellendi!";

        public static string PaymentSuccessful = "Ödeme başarılı!";

        public static string PaymentFailed = "Ödeme başarısız!";

    }
}

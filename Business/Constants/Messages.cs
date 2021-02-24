using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages//static newlememek için
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductsListed="ürünler listelendi";
        public static string ProductCountOfCategoryError="bir kategoride en fazla 10 ürün olabilir.";
        internal static string ProductNameAlreadyExists="bu isimde ürün zaten var";
        internal static string CategoryLimitExceded="kategori limiti aşıldı.yeni ürün eklenemiyor.";
    }
}

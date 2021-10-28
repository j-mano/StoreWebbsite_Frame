using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcess.Modell
{
    public class StoreInfoModell
    {
        [Key]
        public Guid storeId { get; set; }
        public string storeName { get; set; }
        public string storeLocationX { get; set; }
        public string storeLocationY { get; set; }
    }
}

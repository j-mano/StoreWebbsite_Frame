using System;
using System.ComponentModel.DataAnnotations;

namespace DataAcess.Modell
{
    public class ProductModell
    {
        [Key]
        public Guid productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public double price { get; set; }
        public string productType { get; set; }
    }
}

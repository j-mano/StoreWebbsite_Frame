using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAcess.Modell
{
    public class StoreModell
    {
        [Key]
        public Guid storeId { get; set; }
        public string storeName { get; set; }
        public string storeLocationX { get; set; }
        public string storeLocationY { get; set; }
    }
}

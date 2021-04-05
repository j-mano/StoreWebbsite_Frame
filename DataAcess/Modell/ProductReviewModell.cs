using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcess.Modell
{
    public class ProductReviewModell
    {
        [Key]
        [Column(Order = 1)]
        public Guid ReviewIDKey { get; set;}
        [Key]
        [Column(Order = 2)]
        public Guid ProductIDKey { get; set; }
        public string ReviewText { get; set; }
        [Range(0, 5, ErrorMessage = "MUst be betwene 0-5")]
        public int Stars { get; set; }
    }
}

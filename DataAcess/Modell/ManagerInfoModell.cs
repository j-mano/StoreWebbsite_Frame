using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcess.Modell
{
    public class ManagerInfoModell
    {
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid managerId { get; set; }
        [Key]
        [Column(Order = 2)]
        public Guid store { get; set; }
        public string salary { get; set; }
        public string skillLvl { get; set; }
    }
}

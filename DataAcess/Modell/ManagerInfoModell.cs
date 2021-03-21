using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAcess.Modell
{
    public class ManagerInfoModell
    {
        public string name { get; set; }

        [Key]
        public Guid managerId { get; set; }
        public Guid store { get; set; }
        public string salary { get; set; }
        public string skillLvl { get; set; }
    }
}

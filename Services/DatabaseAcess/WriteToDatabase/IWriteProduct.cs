using DataAcess.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.WriteToDatabase
{
    interface IWriteProduct
    {
        Task createProductAsync(ProductModell ínputProduct);
    }
}

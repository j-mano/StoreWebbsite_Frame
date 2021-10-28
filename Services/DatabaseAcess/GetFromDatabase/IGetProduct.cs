using DataAcess.Modell;
using System;
using System.Collections.Generic;

namespace Services.DatabaseAcess.GetFromDatabase
{
    public interface IGetProduct
    {
        List<ProductModell> GetProduct();
    }
}

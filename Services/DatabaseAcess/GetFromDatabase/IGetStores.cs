using DataAcess.Modell;
using System;
using System.Collections.Generic;

namespace Services.DatabaseAcess.GetFromDatabase
{
    public interface IGetStores
    {
        List<StoreInfoModell> getStores();
    }
}

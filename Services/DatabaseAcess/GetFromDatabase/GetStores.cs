using DataAcess.Context;
using DataAcess.Modell;
using Services.DatabaseAcess.Database;
using Services.DatabaseAcess.GetFromDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DatabaseAcess
{
    public class GetStores : DatabaseConection, IGetStores
    {
        public List<StoreInfoModell> getStores()
        {
            List<StoreInfoModell> loadedStores = new List<StoreInfoModell>();
                try
                {
                    Task AsynGetStoreTask = Task.Run(() =>
                    {
                        loadedStores = (from Stores in StoresContext.StoreInfo select Stores).ToList();
                    });

                    AsynGetStoreTask.Wait();

                    return loadedStores;
                }
                catch (Exception e)
                {
                    throw;
                }
        }
    }
}

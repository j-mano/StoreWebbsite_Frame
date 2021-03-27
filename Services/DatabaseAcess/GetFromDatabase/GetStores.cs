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
        public List<StoreModell> getStores()
        {
            List<StoreModell> loadedStores = new List<StoreModell>();
                try
                {
                    Task AsynGetStoreTask = Task.Run(() =>
                    {
                        loadedStores = (from Stores in StoresContext.StoreInfo select Stores).ToList();
                    });

                    AsynGetStoreTask.Wait();

                    return loadedStores;
                }
                catch
                {
                    throw;
                }
        }
    }
}

using DataAcess.Modell;
using Services.DatabaseAcess.Database;
using Services.DatabaseAcess.GetFromDatabase;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.DatabaseAcess
{
    public class GetProducts : DatabaseConection, IGetProduct
    {
        public List<ProductModell> GetProduct()
        {
            List<ProductModell> loadedProducts = new List<ProductModell>();
                try
                {
                    Task AsynGetStoreTask = Task.Run(() =>
                    {
                        loadedProducts = (from Product in ProductsContext.Products select Product).ToList();
                    });

                        AsynGetStoreTask.Wait();
                        return loadedProducts;
                    }
                catch
                {
                    throw;
                }
        }
    }
}

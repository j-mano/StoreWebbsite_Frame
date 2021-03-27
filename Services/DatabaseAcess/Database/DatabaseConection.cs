using DataAcess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.Database
{
    public class DatabaseConection
    {
        public static ManagerContext ManagersContext  = new ManagerContext();
        public static ProductContext ProductsContext  = new ProductContext();
        public static StoreContext StoresContext      = new StoreContext();
    }
}

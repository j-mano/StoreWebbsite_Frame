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
    public class GetManagers : DatabaseConection, IGetManagers
    {
        /// <summary>
        /// Get all manager in the database.
        /// </summary>
        /// <returns></returns>
        public List<ManagerInfoModell> getManagers()
        {
            List<ManagerInfoModell> Managers = new List<ManagerInfoModell>();
                try
                {
                    Task AsynGetStoreTask = Task.Run(() =>
                    {
                        Managers = (from manager in ManagersContext.ManagerInfo select manager).ToList();
                    });

                    AsynGetStoreTask.Wait();
                
                    return Managers;
                }
                catch
                {
                    throw;
                }
        }
    }
}

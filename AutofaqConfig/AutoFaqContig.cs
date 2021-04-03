using Autofac;
using Services.DatabaseAcess;
using Services.DatabaseAcess.GetFromDatabase;
using System.Linq;
using System.Reflection;

namespace StoreWebbsite_Frame.AutofaqConfig
{
    public static class AutoFaqContig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // GetListsFromDatabaseFunctions.
            builder.RegisterType<GetProducts>().As<IGetProduct>();
            builder.RegisterType<GetManagers>().As<IGetManagers>();
            builder.RegisterType<GetStores>().As<IGetStores>();
            builder.RegisterType<GetReviewByProductID>().As<IGetReviewByProductID>();

            // GoogleServises
            // Not implemented yet

            return builder.Build();
        }
    }
}
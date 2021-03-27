using Autofac;
using Services.DatabaseAcess;
using Services.DatabaseAcess.GetFromDatabase;
using StoreWebbsite_Frame.aplication;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace StoreWebbsite_Frame.AutofaqConfig
{
    public static class AutoFaqContig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Aplication>().As<IAplication>();

            // GetListsFromDatabaseFunctions.
            builder.RegisterType<GetProducts>().As<IGetProduct>();
            builder.RegisterType<GetManagers>().As<IGetManagers>();
            builder.RegisterType<GetStores>().As<IGetStores>();

            // GoogleServises
            // Not implemented yet

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataAcess)))
                    .Where(t => t.Namespace.Contains("Utilities"))
                    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
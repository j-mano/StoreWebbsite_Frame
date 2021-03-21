using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace StoreWebbsite_Frame.AutofaqConfig
{
    public class AutoFaqContig
    {
        public static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

           // builder.RegisterType<Application>().As<IAplication>();
           // builder.RegisterType<CordinatesModells>().As<ICordinatesModells>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataAcess)))
                    .Where(t => t.Namespace.Contains("Utilities"))
                    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
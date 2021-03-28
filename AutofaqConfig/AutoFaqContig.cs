﻿using Autofac;
using Services.DatabaseAcess;
using Services.DatabaseAcess.GetFromDatabase;
using StoreWebbsite_Frame.aplication;
using System.Linq;
using System.Reflection;

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

            return builder.Build();
        }
    }
}
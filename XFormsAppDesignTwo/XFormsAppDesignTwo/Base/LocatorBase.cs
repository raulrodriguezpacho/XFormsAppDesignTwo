using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Text;
using XFormsAppDesignTwo.Models;
using XFormsAppDesignTwo.Services;
using XFormsAppDesignTwo.ViewModels;

namespace XFormsAppDesignTwo.Base
{
    public static class LocatorBase
    {
        private static bool _mock;

        private static IContainer _container;
        public static IContainer Container
        {
            get
            {
                return _container;
            }
        }

        public static void Register(IModule module = null, bool mock = false)
        {
            _mock = mock;
            var builder = new ContainerBuilder();
            RegisterServices(builder);
            RegisterViewModels(builder);
            if (module != null) RegisterPlatformModule(builder, module);
            _container = builder.Build();
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            if (!_mock)
            {
                builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
                builder.RegisterType<ItemsDataStoreService>().As<IDataStoreService<Item>>();
                // more services..

            }
            else
            {
                builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
                builder.RegisterType<MockItemsDataStoreService>().As<IDataStoreService<Item>>();
                // more services..
            }
        }

        private static void RegisterViewModels(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<OtherViewModel>();
            // more viewmodels..

        }

        private static void RegisterPlatformModule(ContainerBuilder builder, IModule module)
        {
            builder.RegisterModule(module);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}

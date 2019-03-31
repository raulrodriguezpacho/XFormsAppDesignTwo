using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Foundation;
using UIKit;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.iOS.Services
{
    public class PlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<AppVersionService>().As<IAppVersionService>();
            builder.RegisterType<DeviceService>().As<IDeviceService>();
            // more Android platform services..

        }
    }
}
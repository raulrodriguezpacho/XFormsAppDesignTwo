using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Services;
using XFormsAppDesignTwo.UWP.Services.Device;

namespace XFormsAppDesignTwo.UWP.Services
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

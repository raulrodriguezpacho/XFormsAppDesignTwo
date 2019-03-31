using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.Droid.Services
{
    class AppVersionService : IAppVersionService
    {
        public int GetBuild()
        {
            try
            {
                var context = global::Android.App.Application.Context;
                PackageManager manager = context.PackageManager;
                PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);
                return info.VersionCode;
            }
            catch { return 4; }
        }

        public string GetVersion()
        {
            try
            {
                var context = global::Android.App.Application.Context;
                PackageManager manager = context.PackageManager;
                PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);
                return info.VersionName;
            }
            catch { return "4.0"; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.Droid.Services
{
    class DeviceService : IDeviceService
    {
        public Size GetDeviceSize()
        {
            var context = Forms.Context;
            return new Size()
            {
                Width = context.Resources.DisplayMetrics.WidthPixels / context.Resources.DisplayMetrics.Density,
                Height = context.Resources.DisplayMetrics.HeightPixels / context.Resources.DisplayMetrics.Density
            };
        }
    }
}
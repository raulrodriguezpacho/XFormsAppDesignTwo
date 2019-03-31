using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.iOS.Services
{
    class DeviceService : IDeviceService
    {
        public Size GetDeviceSize()
        {
            return new Size()
            {
                Width = UIScreen.MainScreen.Bounds.Width,
                Height = UIScreen.MainScreen.Bounds.Height
            };
        }
    }
}
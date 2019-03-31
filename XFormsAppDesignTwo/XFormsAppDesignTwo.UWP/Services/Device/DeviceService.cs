using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Xamarin.Forms;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.UWP.Services.Device
{
    class DeviceService : IDeviceService
    {
        public Size GetDeviceSize()
        {
            var applicationView = ApplicationView.GetForCurrentView();
            var displayInformation = DisplayInformation.GetForCurrentView();
            var bounds = applicationView.VisibleBounds;
            var scale = displayInformation.RawPixelsPerViewPixel;
            var size = new Size(bounds.Width * scale, bounds.Height * scale);
            return size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.iOS.Services
{
    public class AppVersionService : IAppVersionService
    {
        public int GetBuild()
        {
            try
            {
                return int.Parse(NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString());
            }
            catch { return 4; }
        }

        public string GetVersion()
        {
            try
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
            }
            catch { return "4.0"; }
        }
    }
}
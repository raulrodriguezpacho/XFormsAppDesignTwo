using System;
using System.Collections.Generic;
using System.Text;

namespace XFormsAppDesignTwo.Config
{
    public class Settings
    {
        private static Settings current = null;
        protected Settings() { }
        public static Settings Current
        {
            get
            {
                if (current == null)
                    current = new Settings();
                return current;
            }
        }

        public string URL
        {
            get => Xamarin.Essentials.Preferences.Get(nameof(URL), "https://www.raulrodriguezpacho.com/api/");
        }

        public int RequestTimeout
        {
            get => Xamarin.Essentials.Preferences.Get(nameof(RequestTimeout), 15000);
        }

        public string URLQuery
        {
            get => Xamarin.Essentials.Preferences.Get(nameof(URLQuery), "query?id={0}");
        }
    }
}

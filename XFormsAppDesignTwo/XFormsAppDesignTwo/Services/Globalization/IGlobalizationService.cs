using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace XFormsAppDesignTwo.Services
{
    public interface IGlobalizationService
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}

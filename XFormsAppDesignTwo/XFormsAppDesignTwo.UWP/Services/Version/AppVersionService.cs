using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.UWP.Services
{
    class AppVersionService : IAppVersionService
    {
        public int GetBuild()
        {
            return 0;
        }

        public string GetVersion()
        {
            return "0";
        }
    }
}

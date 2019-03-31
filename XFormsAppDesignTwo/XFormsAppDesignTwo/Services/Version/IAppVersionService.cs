using System;
using System.Collections.Generic;
using System.Text;

namespace XFormsAppDesignTwo.Services
{
    public interface IAppVersionService
    {
        string GetVersion();
        int GetBuild();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Models;

namespace XFormsAppDesignTwo.Services.Repository
{
    class CustomRepositoryService : RepositoryService<Item>, ICustomRepositoryService
    {
        public Task<bool> CustomMethod()
        {
            throw new NotImplementedException();
        }
    }
}

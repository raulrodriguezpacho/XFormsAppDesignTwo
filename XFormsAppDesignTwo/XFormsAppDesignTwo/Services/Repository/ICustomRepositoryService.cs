using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Models;

namespace XFormsAppDesignTwo.Services
{
    interface ICustomRepositoryService : IRepositoryService<Item>
    {
        Task<bool> CustomMethod();
    }
}
